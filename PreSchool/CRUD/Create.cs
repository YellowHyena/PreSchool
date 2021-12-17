using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.CRUD
{
    internal class Create
    {
        public static void Child(Child tempChild)
        {
            using var db = new SchoolContext();
            var child = db.Children.FirstOrDefault(s => s.PersonalNumber == tempChild.PersonalNumber);
            if (child == null)
            {
                db.Children.Add(new Child
                {
                    FirstName = tempChild.FirstName,
                    LastName = tempChild.LastName,
                    PersonalNumber = tempChild.PersonalNumber,
                    PublicPreSchool = tempChild.PublicPreSchool,
                    FifteenHours = tempChild.FifteenHours,
                    StartDate = tempChild.StartDate,
                    EndDate = tempChild.EndDate,
                    BillRecipent = tempChild.BillRecipent,
                    ApplicationDate = tempChild.ApplicationDate
                });
                db.SaveChanges();
            }
        }
    }
}
