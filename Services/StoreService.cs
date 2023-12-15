using BusinessEntity;
using Microsoft.Data.SqlClient;
using SmsPanel.Controllers;
using SmsPanel.Models.Dto;

namespace SmsPanel.Services
{
    public class StoreService
    {
        string ConnectionString = "Data Source=185.252.29.60,2022;Initial Catalog=crmirani_dbcrm;User ID=crmirani_arman;Password=Arman@papi@1378@; Encrypt=false; TrustServerCertificate=True";
        public StoreDto GetData(string IdStore)
        {
            StoreDto data = new StoreDto();
            string Query = "SELECT * FROM [Stores] where [idStoreEncriptSMS] = @idStoreEncriptSMS";
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@idStoreEncriptSMS", IdStore);
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    data.id = (long)reader["id"];
                    data.Name = (string)reader["Name"];
                    data.Family = (string)reader["Family"];
                    data.idStore = (string)reader["idStore"];
                    data.idStoreEncriptSMS = (string)reader["idStoreEncriptSMS"];
                    data.PriceFinal = SeparateHundred(reader["PriceFinal"].ToString());
                    data.Phone = (string)reader["Phone"];
                    data.Date = (string)reader["Date"];
                    data.Time = (string)reader["Time"];
                    data.Card = SeparateHundred((string)reader["Card"].ToString());
                    data.Cash = SeparateHundred((string)reader["Cash"].ToString());
                    data.Account = SeparateHundred((string)reader["Account"].ToString());
                    data.Price = SeparateHundred((string)reader["Price"].ToString());
                    data.SumCount = (string)reader["SumCount"];
                    data.Discount = SeparateHundred((string)reader["Discount"].ToString());
                    data.VAT = SeparateHundred((string)reader["VAT"].ToString());
                    data.DiscountRandom = SeparateHundred((string)reader["DiscountRandom"].ToString());
                    data.PriceKharidAll = SeparateHundred((string)reader["PriceKharidAll"].ToString());
                    data.idCashier = (string)reader["idCashier"];
                    data.idPay = (string)reader["idPay"];
                    data.Status = (bool)reader["Status"];
                    foreach (var item in GetStoreListKala(data.id))
                    {
                        data.StoreListKala.Add(item);
                    }
                }
                reader.Close();
                Connection.Close();
            }
            return data;
        }

        public List<StoreListKalaDto> GetStoreListKala(long IdStore)
        {
            List<StoreListKalaDto> lst = new List<StoreListKalaDto>();
            string Query = "SELECT * FROM [StoreListKalas] where [StoreID] = @IdStore";
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@IdStore", IdStore);
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    StoreListKalaDto data = new StoreListKalaDto();
                    data.id = (long)reader["id"];
                    data.GoodNameGoodBrand = (string)reader["GoodNameGoodBrand"];
                    data.tedad = (double)reader["tedad"];
                    data.price = SeparateHundred((string)reader["price"].ToString());
                    data.Discount = SeparateHundred((string)reader["Discount"].ToString());
                    data.PriceKharid = SeparateHundred((string)reader["PriceKharid"].ToString());
                    data.PriceAll = SeparateHundred((string)reader["PriceAll"].ToString());
                    data.StoreID = (long)reader["StoreID"];
                    lst.Add(data);
                }
                reader.Close();
                Connection.Close();
            }
            return lst;
        }

        public string SeparateHundred(string TextPrice)
        {
            try
            {
                if (TextPrice.Length > 0)
                {
                    TextPrice = TextPrice.Replace(",", "");
                    TextPrice = String.Format("{0:N0}", long.Parse(TextPrice));
                    return TextPrice;
                }
                return "0";
            }
            catch
            {
                return "0";
            }
        }
    }
}
