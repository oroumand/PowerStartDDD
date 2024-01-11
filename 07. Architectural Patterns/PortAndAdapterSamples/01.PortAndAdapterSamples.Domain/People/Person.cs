using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PortAndAdapterSamples.Domain.People
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Rename(string newFirstName,string newLastName)
        {

        }
    }

    public interface IPersonRepository
    {
        Person Get(int id);
        void Save(Person person);
        void Delete(int id);
        void Commit();
        void BeginTran();
    }
}
