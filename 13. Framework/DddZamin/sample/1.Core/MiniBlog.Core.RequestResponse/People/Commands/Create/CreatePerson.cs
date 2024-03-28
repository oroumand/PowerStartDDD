using DddZamin.Core.RequestResponse.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Core.RequestResponse.People.Commands.Create
{
    public class CreatePerson:ICommand<int>
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
