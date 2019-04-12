using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class AccountRepository
    {
        public string connectionString = @"Server = kubisova\sql2014; Database = TransformerbankDb;Trusted_Connection = true";

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Account as a inner join Client as c on a.ClientId = c.ClientId";
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account account  = new Account();
                            account.Id = reader.GetInt32(0);
                            //account.ClientId = reader.GetInt32(1);
                            account.Iban = reader.GetString(2);
                            account.EstablishDate = reader.GetDateTime(3);
                            account.CancelDate = reader.GetDateTime(4);
                            account.AccountBalance = reader.GetDecimal(5);
                            account.OverdraftLimit = reader.GetDecimal(6);
                            account.AmmountOfOverdraft = reader.GetDecimal(7);
                            account.client.Id = reader.GetInt32(8);
                            account.client.Name = reader.GetString(9);
                            account.client.Surname = reader.GetString(10);
                            account.client.OpNumber = reader.GetString(11);
                            account.client.Street = reader.GetString(12);
                            account.client.Name = reader.GetString(13);
                            account.client.StreetNumber = reader.GetString(14);
                            account.client.City = reader.GetString(15);
                            account.client.Contact = reader.GetString(16);
                        }
                    }
                }
            }

            return accounts;
        }
    }
}
