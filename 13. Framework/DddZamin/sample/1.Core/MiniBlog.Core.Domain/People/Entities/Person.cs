using DddZamin.Core.Domain.Entities;
using DddZamin.Core.Domain.Exceptions;
using MiniBlog.Core.Domain.People.DomainEvents;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Core.Domain.Resources;

namespace MiniBlog.Core.Domain.People.Entities
{
    public class Person : AggregateRoot<int>
    {
        #region Properties
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        #endregion

        public Person(int id, string firatName, string lastName)
        {
            if (id < 1)
            {
                throw new InvalidEntityStateException(MessagePatterns.IdValidationMessage);
            }
            Id = id;
            FirstName = firatName;
            LastName = lastName;
            AddEvent(new PersonCreated(id, BusinessId.Value, firatName, lastName));

        }
    }
}
