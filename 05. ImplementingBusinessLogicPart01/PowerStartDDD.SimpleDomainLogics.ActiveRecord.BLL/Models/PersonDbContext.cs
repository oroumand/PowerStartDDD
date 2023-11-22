using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStartDDD.SimpleDomainLogics.ActiveRecord.BLL.Models
{
    public class PersonDbContext:DbContext   
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog=PersonDb;User Id=sa; Password=1qaz!QAZ; Trusted_Connection=True;")
        }
    }
}
