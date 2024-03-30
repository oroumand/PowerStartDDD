using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DddZamin.Core.Domain.Toolkits.ValueObjects;

namespace DddZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class TitleConversion : ValueConverter<Title, string>
    {
        public TitleConversion() : base(c => c.Value, c => Title.FromString(c))
        {

        }
    }
}
