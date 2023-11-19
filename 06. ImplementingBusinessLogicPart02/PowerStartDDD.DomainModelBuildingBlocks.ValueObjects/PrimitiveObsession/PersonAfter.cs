namespace PowerStartDDD.DomainModelBuildingBlocks.ValueObjects.PrimitiveObsession
{
    public class PersonAfter(Id id, Name name, Email email, NationalCode code)
    {
        public Id Id { get; private set; } = id;
        public Name Name { get; private set; } = name;
        public Email Email { get; private set; } = email;
        public NationalCode NationalCode { get; private set; } = code;
    }
    public class Name(string firstName,string lastName)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;
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
