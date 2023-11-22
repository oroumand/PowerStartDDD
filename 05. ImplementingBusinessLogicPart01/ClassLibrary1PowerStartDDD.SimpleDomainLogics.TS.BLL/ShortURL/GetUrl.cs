using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1PowerStartDDD.SimpleDomainLogics.TS.BLL.ShortURL
{
    public class GetUrl
    {
        public string Execute(string shortUrl)
        {
            //Transaction Start

            string url = "";
            SqlConnection connection = new("Server=.; Initial Catalog=ShortUrlDb;User Id=sa; Password=1qaz!QAZ; Trusted_Connection=True;");
            string code = DateTime.Now.Ticks.ToString();
            SqlCommand cmd = connection.CreateCommand();




            cmd.CommandText = $"Select * from ShortUrls where ShortUrl = '{shortUrl}'";
            connection.Open();

            //Update View Count


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                url = dr["URL"].ToString();
            }




            connection.Close();
            //Transactin Commit
            return url;
        }
    }
}
