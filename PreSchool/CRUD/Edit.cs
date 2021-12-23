using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Edit
    {
        //I could probably use some sort of Builder or Factory or whatever here so I wouldn't have so much code that looks almost the same
        //but I'm still not 100% sure how to use Builders and Factories and don't have the time or energy to check. And this still works, it just looks messier. (thanks to regions its ok)
        //Plus when I've tried to substitute each db."whatever" with a variable it wont work so and I'm not sure why :(
        //I'll read more about them after Christmas

        //Edit class does basically the same as Create class but it uses dummys Id to match with an existing person

        #region Child
        public static void Child(Dummy dummy) //gets dummys info and updates it to child with same id as dummy, then attach new group to child
        {
            using var db = new SchoolContext();
            var child = db.Children.FirstOrDefault(s => s.Id == dummy.Id);

            child.FirstName = dummy.FirstName;
            child.LastName = dummy.LastName;
            child.PersonalNumber = dummy.PersonalNumber;
            child.StartDate = dummy.StartDate;
            child.EndDate = dummy.EndDate;
            child.ApplicationDate = dummy.ApplicationDate;

            db.Children.Update(child);
            db.SaveChanges();

            child = db.Children.Include("Groups").FirstOrDefault(s => s.Id == dummy.Id);
            EditChildGroup(child, dummy.Group);
        }
        
        private static void EditChildGroup(Child child, string dummyGroup) //It basically deletes what group you have attatched and then attatches a new one
        {
            using var db = new SchoolContext();
            db.Children.Attach(child);

            var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name == dummyGroup);
            if (child.Groups != null) child.Groups.Clear();
            else child.Groups = new List<Group>();

            child.Groups.Add(group);
            db.Children.Update(child);
            db.SaveChanges();
        }
        #endregion

        //As in Create, Guardian region is basically Child region but with a Guardian instead and changes Child instead of Group
        #region Guardian
        public static void Guardian(Dummy dummy)
        {
            using var db = new SchoolContext();
            var guardian = db.Guardians.FirstOrDefault(s => s.Id == dummy.Id);

            guardian.FirstName = dummy.FirstName;
            guardian.LastName = dummy.LastName;
            guardian.PersonalNumber = dummy.PersonalNumber;
            guardian.PhoneNumber = dummy.PhoneNumber;

            db.Guardians.Update(guardian);
            db.SaveChanges();

            guardian = db.Guardians.Include("Children").FirstOrDefault(s => s.Id == dummy.Id);
            EditGuardianChild(guardian, dummy.Child);
        }
        public static void EditGuardianChild(Guardian guardian, string dummyChild)
        {
            using var db = new SchoolContext();
            db.Guardians.Attach(guardian);
            string[] childName = dummyChild.Split(' ');
            var child = db.Children.Include("Guardians").FirstOrDefault(p => p.FirstName == childName[0] && p.LastName == childName[1]);
            if (guardian.Children != null) guardian.Children.Clear();
            else guardian.Children = new List<Child>();

            guardian.Children.Add(child);
            db.Guardians.Update(guardian);
            db.SaveChanges();
        }
        #endregion

        //And Employee region is just Child region but Employee instead
        #region Employee
        public static void Employee(Dummy dummy)
        {
            using var db = new SchoolContext();
            var employee = db.Employees.FirstOrDefault(s => s.Id == dummy.Id);

            employee.FirstName = dummy.FirstName;
            employee.LastName = dummy.LastName;
            employee.PersonalNumber = dummy.PersonalNumber;
            employee.PhoneNumber = dummy.PhoneNumber;
            employee.EmployementDate = dummy.EmployementDate;

            db.Employees.Update(employee);
            db.SaveChanges();

            employee = db.Employees.Include("Groups").FirstOrDefault(s => s.Id == dummy.Id);
            EditEmployeeGroup(employee, dummy.Group);
        }
        private static void EditEmployeeGroup(Employee employee, string dummyGroup)
        {
            using var db = new SchoolContext();
            db.Employees.Attach(employee);

            var group = db.Groups.Include("Employees").FirstOrDefault(p => p.Name == dummyGroup);
            if (employee.Groups != null) employee.Groups.Clear();
            else employee.Groups = new List<Group>();

            employee.Groups.Add(group);
            db.Employees.Update(employee);
            db.SaveChanges();
        }
        #endregion
    }
}
