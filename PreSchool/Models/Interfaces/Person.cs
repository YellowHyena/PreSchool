namespace PreSchool.Models
{
    internal interface Person
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long PersonalNumber { get; set; }
        int Age { get; }

        string Street { get; set; }
        string City { get; set; }
        string PostCode { get; set; }

    }
}
