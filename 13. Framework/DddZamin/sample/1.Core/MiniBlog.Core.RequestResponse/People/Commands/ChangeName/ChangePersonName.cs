using DddZamin.Core.RequestResponse.Commands;

namespace MiniBlog.Core.RequestResponse.People.Commands.Create
{
    public class ChangePersonName:ICommand<int>
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
    }
}
