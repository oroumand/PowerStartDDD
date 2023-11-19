namespace PowerStartDDD.DomainModelBuildingBlocks.ValueObjects.PrimitiveObsession
{
    public class PersonBefor(int id, string firstName, string lastName, string email, string nationalCode)
    {
        public int Id { get; set; } = id;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string Email { get; set; } = email;
        public string NationalCode { get; set; } = nationalCode;
    }
}
