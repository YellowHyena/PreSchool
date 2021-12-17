namespace PreSchool.Models
{
    using PreSchool.Database;
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        } 

        public List<Address> AddressesInfo { get; set; }
        public List<Adult> Guairdians { get; set; }
        public bool PublicPreSchool { get; set; } = false;
        public bool FifteenHours { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDate { get; set; }

        public List<Group> Groups { get; set; }

        public int BillRecipent { get; set; } //adultid
    }

    public class Adult
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        }
        public List<Address> AddressesInfo { get; set; }

        public List<Child> Children { get; set; } 

        public string IncomeInfo { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public int DebitFee { get; set; }
        

    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        }

        public List<Address> AddressesInfo { get; set; }
        public string Group { get; set; }

    }

    public class PeopleHelper   //Hallå vart tog referenslänken vägen??? Fixa
    {
        public static int GetAge(long personalNumber)
        {
            int year = (int)((personalNumber / 100000000));

            int month = (int)((personalNumber / 1000000) % 100);

            int day = (int)((personalNumber / 10000) % 100);

            DateTime birth = new DateTime(year, month, day);
            DateTime today = DateTime.Now.Date;
            DateTime birthDay = new DateTime(today.Year, month, day);

            int birthdayAdjustment = today < birthDay ? -1 : 0;
            int age = today.Year - birth.Year + birthdayAdjustment;

            return age;
        }
    }
}
