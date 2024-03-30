using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DddZamin.Core.Domain.Toolkits.ValueObjects;

namespace DddZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class DescriptionConversion : ValueConverter<Description, string>
    {
        public DescriptionConversion() : base(c => c.Value, c => Description.FromString(c))
        {

        }
    }
}
