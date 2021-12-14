namespace PreSchool.Models
{
    public class Child : Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        } 

        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public int Guardian1 { get; set; } //AdultId
        public int Guardian2 { get; set; } //AdultId 
        public bool PublicPreSchool { get; set; } = false;
        public bool FifteenHours { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDate { get; set; }

        public string Unit { get; set; } // koppla till avdelning
    }

    public class Adult : Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        }  
        public string Street { get; set; } //
        public string City { get; set; } //
        public string PostCode { get; set; } // samla dessa tre som adress?

        public int GuardianFor { get; set; } //Child where Guiardian.Id || Guardian.Id == adult.id typ

        public string IncomeInfo { get; set; }
        public string MaxTax { get; set; }

        public string PhoneNumber { get; set; }

        public int DebitFee { get; set; }
        public int BillRecipent { get; set; } // Borde väll va på barnet?

    }

    public class Employee : Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long PersonalNumber { get; set; }
        public int Age
        {
            get { return PeopleHelper.GetAge(PersonalNumber); }
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

    }

    public class PeopleHelper
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
