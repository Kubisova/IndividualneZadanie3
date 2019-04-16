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
        /// <summary>
        /// Metoda, ktora vrati posledne vydane cislo karty
        /// </summary>
        /// <returns></returns>
        public int GetLastIssuedCardNumber()
        {
            int maxCardNumber;
            
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
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

        /// <summary>
        /// Metoda, ktora vrati z databazy posledny vydany pin
        /// </summary>
        /// <returns></returns>
        public int GetLastIssuedCardPin()
        {
            int maxCardPin;

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
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

        /// <summary>
        /// Metoda, ktora prida kartu do databazy
        /// </summary>
        /// <param name="card"></param>
        /// <param name="accountId"></param>
        public void AddNewCard(Card card, int accountId)
        {
            bool success;
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                int cardId;

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Card output inserted.CardId 
                                                values(@cardNumber, @pin, @cardValidity, @isBlocked)";

                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = card.CardNumber;
                    command.Parameters.Add("@pin", SqlDbType.Int).Value = card.Pin;
                    command.Parameters.Add("@cardValidity", SqlDbType.Date).Value = card.CardValidity;
                    command.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = card.IsBlocked;

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

        /// <summary>
        /// Metoda, ktora vrati z databazy karty podla cisla uctu
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<Card> GetCardsByAccountId(int accountId)
        {
            List<Card> cards = new List<Card>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = @"Select CardNumber, Pin, CardValidity, IsBlocked 
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
                            card.IsBlocked = reader.GetBoolean(3);

                            cards.Add(card);
                        }
                    }
                }
            }

            return cards;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy pin podla cisla karty
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public int GetPinByCardNumber(int cardNumber)
        {
            int pin;

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select * from Card where CardNumber = @cardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pin = reader.GetInt32(2);
                        }
                        else
                        {
                            pin = 0;
                        }
                    }

                    return pin;
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy datum zrusenia uctu podla cisla karty
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public DateTime GetAccountCancelDate(int cardNumber)
        {
            DateTime cancelDate;

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Select *
                                            from Account as a
                                            inner join AccountCard as ac
                                            on a.AccountId = ac.AccountId
                                            inner join Card as c
                                            on c.CardId  = ac.CardId
                                            where CardNumber = @cardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cancelDate = reader.IsDBNull(5)? DateTime.MinValue : reader.GetDateTime(5);
                        }
                        else
                        {
                            cancelDate = DateTime.MinValue;
                        }
                    }

                    return cancelDate;
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy datum platnosti karty podla cisla karty
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public DateTime GetCardValidityDate(int cardNumber)
        {
            DateTime validityDate;

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select CardValidity from Card where CardNumber = @cardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    validityDate = (DateTime)command.ExecuteScalar();
                    return validityDate;
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy ci je karta zablokovana
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public bool IsCardBlocked(int cardNumber)
        {
            bool isBlocked;

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select IsBlocked from Card where CardNumber = @cardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    isBlocked = (bool)command.ExecuteScalar();
                    return isBlocked;
                }
            }
        }

        /// <summary>
        /// Metoda, ktora nastavi v databaze karu ako zablokovanu
        /// </summary>
        /// <param name="cardNumber"></param>
        public void SetCardAsBlocked(int cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Card set IsBlocked = @isBlocked where CardNumber = @cardNumber";

                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;
                    command.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = 1;

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Metoda, ktora este nefunguje, ale v buducnosti nastavi kartu v databaze ako nezablokovanu
        /// </summary>
        /// <param name="accountId"></param>
        public void SetCardAsNotBlocked(int accountId)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Card set IsBlocked = @isBlocked where  ....";

                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = 0;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
