using _01.PortAndAdapterSamples.Domain.People;
using Microsoft.EntityFrameworkCore;

namespace _03.PortAndAdapterSamples.DAL
{
    public class PandAdapterDbContext:DbContext
    {
        public DbSet<Person> MyProperty { get; set; }
    }
}
