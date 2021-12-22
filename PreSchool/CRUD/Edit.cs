using Microsoft.EntityFrameworkCore;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Edit
    {
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
        
        public static void EditChildGroup(Child child, string dummyGroup) //https://www.youtube.com/watch?v=dQw4w9WgXcQ
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
    }
}
