using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ImplementingBusinessLogicPart02.DomainModedl.ValueObjects.Person
{
    public class Person
    {
        public PersonId Id { get; set; }
        public FullName FullName { get; set; }
        public Email Email { get; set; }

        public Person(PersonId id,FullName name, Email email)
        {
            Id = id;
            FullName = name;
            Email = email;
        }
    }

    public class FullName
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public FullName(string firstName,string lastName)
        {
                //Validate

            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Email
    {
        public string Value { get; private set; }

        public Email(string value) {
            //validate
            Value = value;
            
        }
    }

    public class PersonId
    {
        public string Value { get; private set; }
        public PersonId(string value)
        {
            //Vlidate National Id
            Value = value;
        }
    }
}
