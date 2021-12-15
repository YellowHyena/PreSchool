namespace PreSchool.Models
{
    internal interface Person
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        long PersonalNumber { get; set; }
        int Age { get; }
        List<Address> AddressInfo { get; set; }

    }
}
