using _01.PortAndAdapterSamples.Domain.People;

namespace _02.PortAndAdapterSamples.ApplicaitonServices.People
{
    public class CreatePerson
    {
        private readonly IPersonRepository personRepository;

        public CreatePerson(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public void Handle(Person person)
        {
            personRepository.BeginTran();
            personRepository.Save(person);
            personRepository.Commit();
        }
    }
}
