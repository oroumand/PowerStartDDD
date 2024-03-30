using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DddZamin.Core.Domain.Toolkits.ValueObjects;

namespace DddZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class LegalNationalIdConversion : ValueConverter<LegalNationalId, string>
    {
        public LegalNationalIdConversion() : base(c => c.Value, c => LegalNationalId.FromString(c))
        {

        }
    }
}
