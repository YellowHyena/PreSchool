using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Create
    {
        //I could probably use some sort of Builder or Factory or whatever here so I wouldn't have so much code that looks almost the same
        //but I'm still not 100% sure how to use Builders and Factories and don't have the time or energy to check. And this still works, it just looks messier.
        //Plus when I've tried to substitute each class with a variable it wont work so..
        //I'll read more about them after Christmas
        #region Child
        public static void Child(Dummy dummy)
        {
            using var db = new SchoolContext();
            var child = db.Children.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
            if (child == null)
            {
                db.Children.Add(new Child
                {
                    FirstName = dummy.FirstName,
                    LastName = dummy.LastName,
                    PersonalNumber = dummy.PersonalNumber,
                    StartDate = dummy.StartDate,
                    EndDate = dummy.EndDate,
                    ApplicationDate = dummy.ApplicationDate
                });

                db.SaveChanges();
                child = db.Children.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
                AttachGroup(child, dummy.Group);
            }
            else MessageBox.Show("Det finns redan ett barn med det personnummret!");
        }

        public static void AttachGroup(Child child, string dummyGroup)
        {
            using var db = new SchoolContext();
            db.Children.Attach(child);

            var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name == dummyGroup);

            if (child.Groups == null) child.Groups = new List<Group>();

            child.Groups.Add(group);
            db.Children.Update(child);
            db.SaveChanges();
        }
        #endregion

        #region Guardian
        public static void Guardian(Dummy dummy)
        {
            using var db = new SchoolContext();
            var guardian = db.Guardians.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
            if (guardian == null)
            {
                db.Guardians.Add(new Guardian
                {
                    FirstName = dummy.FirstName,
                    LastName = dummy.LastName,
                    PersonalNumber = dummy.PersonalNumber,
                    PhoneNumber = dummy.PhoneNumber,
                });

                db.SaveChanges();
                guardian = db.Guardians.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
                AttachChildToGroup(guardian, dummy.Child);
            }
            else MessageBox.Show("Det finns redan en vårdnadshavare med det personnummret!");
        }

        private static void AttachChildToGroup(Guardian guardian, string dummyChild)
        {
            using var db = new SchoolContext();
            db.Guardians.Attach(guardian);
            string[] childName = dummyChild.Split(' ');
            var child = db.Children.Include("Guardians").FirstOrDefault(p => p.FirstName == childName[0] && p.LastName == childName[1]);

            if (guardian.Children == null) guardian.Children = new List<Child>();

            guardian.Children.Add(child);
            db.Guardians.Update(guardian);
            db.SaveChanges();
        }
        #endregion

        #region Employee
        internal static void Employee(Dummy dummy)
        {
            using var db = new SchoolContext();
            var employee = db.Employees.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
            if (employee == null)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = dummy.FirstName,
                    LastName = dummy.LastName,
                    PersonalNumber = dummy.PersonalNumber,
                    PhoneNumber = dummy.PhoneNumber,
                    EmployementDate = dummy.StartDate,

                });

                db.SaveChanges();
                employee = db.Employees.FirstOrDefault(s => s.PersonalNumber == dummy.PersonalNumber);
                AttachGroupToEmployee(employee, dummy.Group);
            }
            else MessageBox.Show("Det finns redan en anställd med det personnummret!");
        }

        private static void AttachGroupToEmployee(Employee employee, string dummyGroup)
        {
            throw new NotImplementedException();
        }
    }
        #endregion
    
}
