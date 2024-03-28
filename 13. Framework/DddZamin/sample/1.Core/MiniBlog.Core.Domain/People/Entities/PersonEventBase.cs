using DddZamin.Core.Domain.Entities;
using DddZamin.Core.Domain.Exceptions;
using MiniBlog.Core.Domain.People.DomainEvents;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Core.Domain.Resources;

namespace MiniBlog.Core.Domain.People.Entities
{
    public class PersonEventBase : AggregateRoot<int>
    {
        #region Properties
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        #endregion

        public PersonEventBase(int id, string firatName, string lastName)
        {           
            Apply(new PersonCreated(id, BusinessId.Value, firatName, lastName));
        }

        private void On(PersonCreated personCreated)
        {
            if (personCreated.Id < 1)
            {
                throw new InvalidEntityStateException(MessagePatterns.IdValidationMessage);
            }
            Id = personCreated.Id;
            FirstName = personCreated.FirstName;
            LastName = personCreated.LastName;
            BusinessId = personCreated.BusinessId;
        }
    }
}
