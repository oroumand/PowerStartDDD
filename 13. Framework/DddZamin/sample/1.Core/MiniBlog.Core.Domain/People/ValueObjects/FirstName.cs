using DddZamin.Core.Domain.Exceptions;
using DddZamin.Core.Domain.ValueObjects;
using MiniBlog.Core.Domain.Resources;
using DDDZamin.Utilities.Extensions;
namespace MiniBlog.Core.Domain.People.ValueObjects
{
    public class FirstName : BaseValueObject<FirstName>
    {
        public static FirstName FromString(string value) => new(value);
        public string Value { get; private set; }

        public FirstName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidValueObjectStateException(MessagePatterns.EmptyStringValidationMessage, nameof(FirstName));
            }
            if (value.IsLengthBetween(2,50))
            {
                throw new InvalidValueObjectStateException(MessagePatterns.StringLenghtValidationMessage, nameof(FirstName), "2", "50");

            }
            Value = value;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }



        public static explicit operator string(FirstName firstName) => firstName.Value;
        public static implicit operator FirstName(string value) => new(value);
    }
}
