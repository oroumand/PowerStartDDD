using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ImplementingBusinessLogicPart02.DomainModedl.Agg
{
    public class PersonAgg(int id, string firstName, string lastName)
    {
        public int Id { get; set; } = id;
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;

        public void Rename(string firstName, string lastName)
        {
            //validation
            FirstName = firstName;
            LastName = lastName;
        }

        public void Execute(RenameParam param)
        {
            FirstName = param.firatName;
            LastName = param.lastName;
        }
    }

    public record RenameParam(string firatName,string lastName);
}
