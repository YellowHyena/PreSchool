using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreSchool.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int GuardianId { get; set; }
        public int EmployeeId { get; set; }

        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string PostCode { get; set; } = "";

    }
}
