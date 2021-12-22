using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Edit
    {
        #region Child
        public static void Child(Dummy dummy)
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
        
        private static void EditChildGroup(Child child, string dummyGroup) //https://www.youtube.com/watch?v=dQw4w9WgXcQ
        {
            using var db = new SchoolContext();
            db.Children.Attach(child);

            var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name == dummyGroup);
            if (child.Groups != null) child.Groups.Clear();
            child.Groups = new List<Group>();

            child.Groups.Add(group);
            db.Children.Update(child);
            db.SaveChanges();
        }
        #endregion
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
        public static void EditGuardianChild(Guardian guardian, string dummyChild) //https://www.youtube.com/watch?v=dQw4w9WgXcQ
        {
            using var db = new SchoolContext();
            db.Guardians.Attach(guardian);

            var child = db.Children.Include("Guardians").FirstOrDefault(p => p.FirstName == dummyChild);
            if (guardian.Children != null) guardian.Children.Clear();
            guardian.Children = new List<Child>();

            guardian.Children.Add(child);
            db.Guardians.Update(guardian);
            db.SaveChanges();
        }
        #endregion
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
            employee.Groups = new List<Group>();

            employee.Groups.Add(group);
            db.Employees.Update(employee);
            db.SaveChanges();
        }
        #endregion
    }
}
