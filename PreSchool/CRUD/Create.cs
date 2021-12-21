using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Create
    {

        public static void Child(Dummy childInput)
        {
            using var db = new SchoolContext();
            var child = db.Children.FirstOrDefault(s => s.PersonalNumber == childInput.PersonalNumber);
            if (child == null)
            {
                db.Children.Add(new Child
                {
                    FirstName = childInput.FirstName,
                    LastName = childInput.LastName,
                    PersonalNumber = childInput.PersonalNumber,
                    PublicPreSchool = childInput.PublicPreSchool,
                    FifteenHours = childInput.FifteenHours,
                    StartDate = childInput.StartDate,
                    EndDate = childInput.EndDate,
                    //BillRecipent = childInput.BillRecipent,
                    ApplicationDate = childInput.ApplicationDate
                });

                db.SaveChanges();
                child = db.Children.FirstOrDefault(s => s.PersonalNumber == childInput.PersonalNumber);
                AttachGroup(child, childInput.Group);
            }
            else MessageBox.Show("Det finns redan ett barn med det personnummret!");
        }



        public static Child AttachGroup(Child child, string groupInput)
        {
            using (var db = new SchoolContext())
            {
                db.Children.Attach(child);

                var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name == groupInput);

                if (child.Groups == null) child.Groups = new List<Group>();

                child.Groups.Add(group);
                db.Children.Update(child);
                db.SaveChanges();
            }
            return child;
        }
    }
}
