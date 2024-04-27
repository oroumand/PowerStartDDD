using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Entities;

namespace JobSearcher.Core.Domain.Advertisements.Entities
{
    public class Course:Entity<int>
    {
        public string Name { get;private set; }
        public int Length { get; private set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
