using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

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
        public static void CreateChildren()
        {
            using var db = new SchoolContext();
            if (db.Children.Any()) return;

            var knatte = new Dummy
            {
                FirstName = "Barn",
                LastName = "1",
                PersonalNumber = 193710170001,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                ApplicationDate = DateTime.Now,
                Group = "Avdelning Ett"
            };
            Create.Child(knatte);

            var fnatte = new Dummy
            {
                FirstName = "Barn",
                LastName = "2",
                PersonalNumber = 193710170002,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                ApplicationDate = DateTime.Now,
                Group = "Avdelning Två"
            };
            Create.Child(fnatte);

            var tjatte = new Dummy
            {
                FirstName = "Barn",
                LastName = "3",
                PersonalNumber = 193710170003,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                ApplicationDate = DateTime.Now,
                Group = "Avdelning Tre"
            };
            Create.Child(tjatte);
        }
        public static void CreateGuardians()
        {
            using var db = new SchoolContext();
            if (db.Guardians.Any()) return;

            var kalle = new Dummy
            {
                FirstName = "Förälder",
                LastName = "1",
                PersonalNumber = 111122330000,
                PhoneNumber = "313",
                Child = "Barn 1"
            };
            Create.Guardian(kalle);

            var långben = new Dummy
            {
                FirstName = "Förälder",
                LastName = "2",
                PersonalNumber = 111122330001,
                PhoneNumber = "60079",
                Child = "Barn 2"
            };
            Create.Guardian(långben);

            var musse = new Dummy
            {
                FirstName = "Förälder",
                LastName = "3",
                PersonalNumber = 111122330002,
                PhoneNumber = "1",
                Child = "Barn 3"
            };
            Create.Guardian(musse);
        }
        public static void CreateEmployees()
        {
            using var db = new SchoolContext();
            if (db.Employees.Any()) return;

            var magica = new Dummy
            {
                FirstName = "Anställd",
                LastName = "1",
                PersonalNumber = 111122330003,
                PhoneNumber = "666",
                EmployementDate = DateTime.Now,
                Group = "Avdelning Ett"
            };
            Create.Employee(magica);

            var petter = new Dummy
            {
                FirstName = "Anställd",
                LastName = "2",
                PersonalNumber = 111122330004,
                PhoneNumber = "666",
                EmployementDate = DateTime.Now,
                Group = "Avdelning Två"
            };
            Create.Employee(petter);

            var björnbuse = new Dummy
            {
                FirstName = "Anställd",
                LastName = "3",
                PersonalNumber = 111122330005,
                PhoneNumber = "666",
                EmployementDate = DateTime.Now,
                Group = "Avdelning Tre"
            };
            Create.Employee(björnbuse);
        }
    }
}
