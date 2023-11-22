using PowerStartDDD.SimpleDomainLogics.ActiveRecord.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStartDDD.SimpleDomainLogics.ActiveRecord.BLL.PersonServices
{
    public class CreatePerson
    {
        public int Execute(string firstName, string lastName)
        {
            PersonDbContext dbContext = new PersonDbContext();
            Person person = new()
            {
                FirstName = firstName,
                LastName = lastName
            };

            dbContext.People.Add(person);

            dbContext.SaveChanges();
            return person.Id;
        }
    }


    public class UpdatePerson
    {
        public int Execute(int id,string firstName, string lastName)
        {
            PersonDbContext dbContext = new PersonDbContext();
            Person person = dbContext.People.Find(id);
            person.FirstName = firstName;
            person.LastName = lastName;
            dbContext.SaveChanges();
            return person.Id;
        }
    }
}
