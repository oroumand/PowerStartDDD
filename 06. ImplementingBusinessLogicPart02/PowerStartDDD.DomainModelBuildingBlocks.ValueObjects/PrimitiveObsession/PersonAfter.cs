namespace PowerStartDDD.DomainModelBuildingBlocks.ValueObjects.PrimitiveObsession
{
    public class PersonAfter
    {
        public PersonAfter(Id id, string firstName, string lastName, string email, string nationalCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            NationalCode = nationalCode;
        }

        public Id Id { get; private set; } 
        public string FirstName { get; private set; } 
        public string LastName { get; private set; }
        public string Email { get; private set; } 
        public string NationalCode { get; private set; } 
    }
    public class FirstName(string name)
    {
        public string Value { get; private set; } = name;
    }
    public class LastName(string lastName)
    {
        public string Value { get; private set; } = lastName;
    }
    public class Email(string email)
    {
        public string Value { get; private set; } = email;
    }
    public class NationalCode(string nationalCode)
    {
        public string Value { get; private set; } = nationalCode;
    }

    public class Id(int id)
    {
        public int Value { get; private set; } = id;
    }
}
