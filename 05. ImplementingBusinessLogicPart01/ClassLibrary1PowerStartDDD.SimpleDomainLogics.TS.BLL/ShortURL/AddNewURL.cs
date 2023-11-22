using System.Data.SqlClient;

namespace ClassLibrary1PowerStartDDD.SimpleDomainLogics.TS.BLL.ShortURL
{
    public class AddNewURL
    {
        public string Execute(string url)
        {
            SqlConnection connection = new("Server=.; Initial Catalog=ShortUrlDb;User Id=sa; Password=1qaz!QAZ; Trusted_Connection=True;");
            string code = DateTime.Now.Ticks.ToString();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO [dbo].[ShortUrls]([URL],[ShortUrl]) VALUES(N'{url}',N'{code}')";

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return code;
        }
    }
}
