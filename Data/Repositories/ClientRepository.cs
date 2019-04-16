using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data.SqlClient;
using System.Data;

namespace Data.Repositories
{
    public class ClientRepository
    {
        /// <summary>
        /// Metoda, ktora vrati klientov z databazy
        /// </summary>
        /// <returns></returns>
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
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

        /// <summary>
        /// Metoda, ktora vrati z databazy top 10 klientov pre prehlad
        /// </summary>
        /// <returns></returns>
        public DataSet GetTopClients()
        {
            SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING);
            string command = @"Select top 10 c.Name, c.Surname, a.AccountBalance
                                   from Account as a 
                                   inner join Client as c 
                                   on a.ClientId = c.ClientId
                                   where a.CancelDate is null
                                   order by AccountBalance desc";

            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
            {
                adapter.Fill(ds, "TopClients");
            }
            return ds;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy demograficky prehlad
        /// </summary>
        /// <returns></returns>
        public DataSet GetDemography()
        {
            SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING);
            string command = @"Select top 5 c.City, COUNT(*) as 'Clients count'
                               from Account as a 
                               inner join Client as c 
                               on a.ClientId = c.ClientId
                               where a.CancelDate is null
                               group by c.City
                               order by COUNT(*) desc";

            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
            {
                adapter.Fill(ds, "Demography");
            }
            return ds;
        }
    }
}
