using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Create
    {
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

        public static void AttachGroup(Child child, string groupInput)
        {
            using var db = new SchoolContext();
            db.Children.Attach(child);

            var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name == groupInput);

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
                AttachChild(guardian, dummy.Child);
            }
            else MessageBox.Show("Det finns redan ett barn med det personnummret!");
        }

        private static void AttachChild(Guardian? guardian, string childInput)
        {
            using var db = new SchoolContext();
            db.Guardians.Attach(guardian);
            string[] childName = childInput.Split(' ');
            var child = db.Guardians.Include("Children").FirstOrDefault(p => p.FirstName == childName[0] && p.LastName == childName[1]);

            if (guardian.Children == null) guardian.Children = new List<Child>();

            guardian.Children.Add(child);   ///Fixa detta
            db.Guardians.Update(guardian);
            db.SaveChanges();
        }
    }
}
