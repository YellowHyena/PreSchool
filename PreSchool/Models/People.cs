namespace PreSchool.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public long PersonalNumber { get; set; } //It's long instead of string because I had a method to convert it to a birthdate, but got rid of it
        public List<Guardian> Guardians { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDate { get; set; }
        public List<Group> Groups { get; set; }
    }

    public class Guardian
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public long PersonalNumber { get; set; }
        public List<Child> Children { get; set; }
        public string PhoneNumber { get; set; } = "";
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PersonalNumber { get; set; } 
        public string PhoneNumber { get; set; } = "";
        public DateTime EmployementDate { get; set; }
        public List<Group> Groups { get; set; }
    }

    public class Dummy //just a dummy to store info because I don't like windows forms
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public long PersonalNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime EmployementDate { get; set; }
        public string PhoneNumber { get; set; } = "";
        public string Group { get; set; } = "";
        public string Child { get; set; } = "";
    }
}
