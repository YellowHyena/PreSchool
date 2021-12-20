using PreSchool.Database;

namespace PreSchool.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Guardian> Guardian { get; set; }
        public List<Child> Children { get; set; }

        public static void CreateGroups()
        {
            using var db = new SchoolContext();

            if (db.Groups.Any()) return;
            db.Groups.Add(new Group { Name = "Avdelning Ett" });
            db.Groups.Add(new Group { Name = "Avdelning Två" });
            db.Groups.Add(new Group { Name = "Avdelning Tre" });
            db.SaveChanges();
        }
    }
}