namespace PowerStartDDD.DomainModelBuildingBlocks.Aggregates.Aggregates
{
    public class Ticket(Id id)
    {
        public readonly Id Id = id;
        public List<Message> Messages { get; set; }=new List<Message>();

        public void AddMessage(string fromUserName,string message)
        {
            Messages.Add(new Message(fromUserName, message));
        }

        public void Handle(AddMessageParameter value) =>
            AddMessage(value.name, value.message);
    }
}
