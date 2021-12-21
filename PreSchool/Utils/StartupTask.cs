using PreSchool.Database;
using PreSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.Utils
{
    internal class StartupTask
    {
        public static void CreateGroups()
        {
            using var db = new SchoolContext();

            if (db.Groups.Any()) return;
            db.Groups.Add(new Group { Name = "Avdelning Ett" });
            db.Groups.Add(new Group { Name = "Avdelning Två" });
            db.Groups.Add(new Group { Name = "Avdelning Tre" });
            db.SaveChanges();
        }
    //    public static void CreateChildren()
    //    {
    //        using var db = new SchoolContext();

    //        if (db.Children.Any()) return;
    //        db.Children.Add(new Child
    //        { FirstName = "Knatte",
    //            LastName = "Anka",
    //            PersonalNumber = 199011220000,

    //    public int Age
    //    {
    //        get { return PeopleHelper.GetAge(PersonalNumber); }
    //    }

    //    public List<Address> AddressesInfo { get; set; }
    //    public List<Guardian> Guardians { get; set; }
    //    public bool PublicPreSchool { get; set; } = false;
    //    public bool FifteenHours { get; set; } = false;
    //    public DateTime StartDate { get; set; }
    //    public DateTime EndDate { get; set; }
    //    public DateTime ApplicationDate { get; set; }
    //    public List<Group> Groups { get; set; }

    //    public int BillRecipent { get; set; } //adultid
    //});
    //        db.Children.Add(new Child { Name = "Avdelning Två" });
    //        db.Children.Add(new Child { Name = "Avdelning Tre" });
    //        db.SaveChanges();
    //    }
    }
}
