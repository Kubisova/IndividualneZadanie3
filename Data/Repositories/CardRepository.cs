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
    public class CardRepository
    {
        public string connectionString = @"Server = DESKTOP-GKFDQEI\SQLEXPRESS; Database = TransformerbankDb;Trusted_Connection = true";

        public int GetLastIssuedCardNumber()
        {
            int maxCardNumber;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from Card where CardNumber = (select MAX(CardNumber) from Card)";
                    using( SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maxCardNumber = reader.GetInt32(1);
                        }
                        else
                        {
                            maxCardNumber = 0;
                        }
                    }

                    return maxCardNumber;
                }
            }
        }

        public int GetLastIssuedCardPin()
        {
            int maxCardPin;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from Card where Pin = (select MAX(Pin) from Card)";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maxCardPin = reader.GetInt32(2);
                        }
                        else
                        {
                            maxCardPin = 0;
                        }
                    }

                    return maxCardPin;
                }       
            }
        }

        public void AddNewCard(Card card, int accountId)
        {
            bool success;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int cardId;

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Card output inserted.CardId 
                                                values(@cardNumber, @pin, @cardValidity)";

                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = card.CardNumber;
                    command.Parameters.Add("@pin", SqlDbType.Int).Value = card.Pin;
                    command.Parameters.Add("@cardValidity", SqlDbType.Date).Value = card.CardValidity;

                    cardId = Convert.ToInt32(command.ExecuteScalar());
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into AccountCard 
                                                (AccountId, CardId) 
                                                values(@accountId, @cardId)";

                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Parameters.Add("@cardId", SqlDbType.Int).Value = cardId;

                    success = (command.ExecuteNonQuery() > 0);
                }

                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Update Account set CardsCount = (CardsCount + 1) where AccountId = @accountId";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Card> GetCardsByAccountId(int accountId)
        {
            List<Card> cards = new List<Card>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = @"Select CardNumber, Pin, CardValidity 
                                            from Card as c
                                            inner join AccountCard as ac
                                            on c.CardId = ac.CardId
                                            where AccountId = @accountId";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Card card = new Card();
                            card.CardNumber = reader.GetInt32(0);
                            card.Pin = reader.GetInt32(1);
                            card.CardValidity = reader.GetDateTime(2);

                            cards.Add(card);
                        }
                    }
                }
            }

            return cards;
        }
    }
}
