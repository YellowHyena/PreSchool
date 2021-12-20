using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Create
    {

        //public static void Child(Dummy dummy)
        //{
        //    using var db = new SchoolContext();
        //    var child = db.Children.FirstOrDefault(s => s.PersonalNumber == childInput.PersonalNumber);
        //    if (child == null)
        //    {
        //        db.Children.Add(new Child
        //        {
        //            FirstName = childInput.FirstName,
        //            LastName = childInput.LastName,
        //            PersonalNumber = childInput.PersonalNumber,
        //            PublicPreSchool = childInput.PublicPreSchool,
        //            FifteenHours = childInput.FifteenHours,
        //            StartDate = childInput.StartDate,
        //            EndDate = childInput.EndDate,
        //            BillRecipent = childInput.BillRecipent,
        //            ApplicationDate = childInput.ApplicationDate
        //        });
        //        db.SaveChanges();
        //    }
        //    else MessageBox.Show("Det finns redan ett barn med det personnummret!");
        //}



        //public static Child AddGroup(Child child, string groupInput)
        //{
        //    using (var db = new SchoolContext())
        //    {
        //        db.Children.Attach(child); // Se till att databasen förstår att vi
        //                                   // använder en Hero från databasen
        //        var group = db.Groups.Include("Children").FirstOrDefault(p => p.Name ==
        //        groupInput);
        //        if (group == null)
        //        {
        //            group = new Group { Name = groupInput };
        //            db.Groups.Add(group);
        //            db.SaveChanges();
        //        }
        //        if (child.Group == null) child.Group = new List<Group>();
        //        // Dubbelchecka att power inte finns redan
        //        if (child.Group.FirstOrDefault(p => p.Id == group.Id) == null)
        //        {
        //            child.Group.Add(group);
        //            db.Children.Update(child);
        //            db.SaveChanges();
        //        }
        //    }
        //    return child;
        //}
    }
}
