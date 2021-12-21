using PreSchool.Database;

namespace PreSchool.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Guardian> Guardian { get; set; }
        public List<Child> Children { get; set; }        
    }
}