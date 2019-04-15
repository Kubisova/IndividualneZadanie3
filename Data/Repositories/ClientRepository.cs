using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class ClientRepository
    {
        string connectionString = @"Server = kubisova\sql2014; Database = TransformerBankDb;Trusted_Connection = true";

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Clients";
                    command.Connection = connection;

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client();
                            client.Id = reader.GetInt32(0);
                            client.Name = reader.GetString(1);
                            client.Surname = reader.GetString(2);
                            client.OpNumber = reader.GetString(3);
                            client.Street = reader.GetString(4);
                            client.StreetNumber = reader.GetString(5); 
                            client.City = reader.GetString(6); 
                            client.Contact = reader.GetString(7);

                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }
    }
}
