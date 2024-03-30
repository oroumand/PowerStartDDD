using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DddZamin.Core.Domain.Toolkits.ValueObjects;

namespace DddZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class NationalCodeConversion : ValueConverter<NationalCode, string>
    {
        public NationalCodeConversion() : base(c => c.Value, c => NationalCode.FromString(c))
        {

        }
    }
}
