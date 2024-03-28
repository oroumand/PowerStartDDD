using DddZamin.Core.ApplicationServices.Commands;
using DddZamin.Core.RequestResponse.Commands;
using MiniBlog.Core.Contracts.People.Commands;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.RequestResponse.People.Commands.Create;
using Zamin.Utilities;

namespace MiniBlog.Core.ApplicationService.People.Commands.Create
{
    public class ChangePersonNameHandler : CommandHandler<ChangePersonName, int>
    {
        private readonly IPersonCommandRepository repository;

        public ChangePersonNameHandler(ZaminServices zaminServices,IPersonCommandRepository repository) : base(zaminServices)
        {
            this.repository = repository;
        }

        public override async Task<CommandResult<int>> Handle(ChangePersonName command)
        {
            Person person = repository.GetGraph(command.Id);
            person.ChangeFirstName(command.FirstName);
            await repository.CommitAsync();
            return await OkAsync(person.Id);

        }
    }
}
