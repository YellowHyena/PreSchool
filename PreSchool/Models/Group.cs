using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Adult> Adults { get; set; }
        public List<Child> Children { get; set; }


    }
}
