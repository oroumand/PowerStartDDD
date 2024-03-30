using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DddZamin.Core.Domain.ValueObjects;

namespace DddZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class BusinessIdConversion : ValueConverter<BusinessId, Guid>
    {
        public BusinessIdConversion() : base(c => c.Value, c => BusinessId.FromGuid(c))
        {

        }
    }
}
