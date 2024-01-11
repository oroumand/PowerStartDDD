using _01.PortAndAdapterSamples.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PortAndAdapterSamples.DAL.People
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PandAdapterDbContext context;

        public PersonRepository(PandAdapterDbContext context)
        {
            this.context = context;
        }
        public void BeginTran()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
