namespace PowerStartDDD.DomainModelBuildingBlocks.Entities.Entities
{
    internal class Person(Id id, Name name)
    {
        public readonly Id Id = id;
        public Name Name { get; private set; } = name;

        public void Rename(Name name) => Name = name;
    }

    public class Id(int id)
    {
        public readonly int Value = id;
    }

    public class Name(string firstName, string lastName)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;
    }

}
