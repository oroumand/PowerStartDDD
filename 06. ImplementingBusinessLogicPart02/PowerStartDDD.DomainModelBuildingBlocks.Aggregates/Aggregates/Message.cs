namespace PowerStartDDD.DomainModelBuildingBlocks.Aggregates.Aggregates
{
    public class Message(string name,string message)
    {
        public readonly string Name = name;
        public readonly string Value = message;
    }
}
