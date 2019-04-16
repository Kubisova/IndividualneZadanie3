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
    static class Constants
    {
        public const string CONNECTION_STRING = @"Server = kubisova\sql2014; Database = TransformerBankDb;Trusted_Connection = true";

        
    }
    public class AccountRepository
    {
        /// <summary>
        /// Metoda, ktora vrati z databazy karty s klientami
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
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
                            Account account = new Account();
                            Client client = new Client();
                            account.Client = client;
                            account.Id = reader.GetInt32(0);
                            account.Iban = reader.GetString(2);
                            account.EstablishDate = reader.GetDateTime(3);
                            account.CancelDate = reader.IsDBNull(4)? DateTime.MinValue: reader.GetDateTime(4);
                            account.AccountBalance = reader.GetDecimal(5);
                            account.OverdraftLimit = reader.GetDecimal(6);
                            account.AmmountOfOverdraft = reader.GetDecimal(7);
                            account.Client.Id = reader.GetInt32(8);
                            account.Client.Name = reader.GetString(9);
                            account.Client.Surname = reader.GetString(10);
                            account.Client.OpNumber = reader.GetString(11);
                            account.Client.Street = reader.GetString(12);
                            account.Client.StreetNumber = reader.GetString(13);
                            account.Client.City = reader.GetString(14);
                            account.Client.Contact = reader.GetString(15);
                            accounts.Add(account);
                        }
                    }
                }
            }
            return accounts;
        }

        /// <summary>
        /// Metoda, ktora prida ucet do databazy (aj s klientom a kartami)
        /// </summary>
        /// <param name="account"></param>
        public void AddAccount(Account account)
        {
            bool success;
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                int id;
                int accountId;
                int cardId;

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Client output inserted.ClientId 
                                            values(@name, @surname, @opnumber, @street, @streetnumber, @city, @contact )";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = account.Client.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = account.Client.Surname;
                    command.Parameters.Add("@opnumber", SqlDbType.NVarChar).Value = account.Client.OpNumber;
                    command.Parameters.Add("@street", SqlDbType.NVarChar).Value = account.Client.Street;
                    command.Parameters.Add("@streetnumber", SqlDbType.NVarChar).Value = account.Client.StreetNumber;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = account.Client.City;
                    command.Parameters.Add("@contact", SqlDbType.NVarChar).Value = account.Client.Contact;

                    id = Convert.ToInt32(command.ExecuteScalar());
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into Account output inserted.AccountId
                                            values(@clientId, @accountName, @iban, @establishDate, null,0, @overdraftLimit,0, @cardsCount)";

                    command.Parameters.Add("@clientId", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@accountName", SqlDbType.NVarChar).Value = account.AccountName;
                    command.Parameters.Add("@iban", SqlDbType.VarChar).Value = account.Iban;
                    command.Parameters.Add("@establishDate", SqlDbType.Date).Value = account.EstablishDate;
                    command.Parameters.Add("@overdraftLimit", SqlDbType.Decimal).Value = account.OverdraftLimit;
                    command.Parameters.Add("@cardsCount", SqlDbType.Int).Value = account.CardsCount;

                    accountId = Convert.ToInt32(command.ExecuteScalar());
                }

                for (int i = 0; i < account.CardsCount; i++)
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"insert into Card output inserted.CardId 
                                                values(@cardNumber, @pin, @cardValidity,@isBlocked)";

                        command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = account.Cards[i].CardNumber;
                        command.Parameters.Add("@pin", SqlDbType.Int).Value = account.Cards[i].Pin;
                        command.Parameters.Add("@cardValidity", SqlDbType.Date).Value = account.Cards[i].CardValidity;
                        command.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = account.Cards[i].IsBlocked;

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
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vykona edit uctu v databaze
        /// </summary>
        /// <param name="account"></param>
        public void EditAccount(Account account)
        {
            //bool success;
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Client 
                                            set Name = @name, 
                                                Surname = @surname, 
                                                OpNumber = @opnumber, 
                                                Street = @street, 
                                                StreetNumber = @streetnumber, 
                                                City = @city, 
                                                Contact = @contact
                                            where ClientId = @clientId";

                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = account.Client.Name;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = account.Client.Surname;
                    command.Parameters.Add("@opnumber", SqlDbType.NVarChar).Value = account.Client.OpNumber;
                    command.Parameters.Add("@street", SqlDbType.NVarChar).Value = account.Client.Street;
                    command.Parameters.Add("@streetnumber", SqlDbType.NVarChar).Value = account.Client.StreetNumber;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = account.Client.City;
                    command.Parameters.Add("@contact", SqlDbType.NVarChar).Value = account.Client.Contact;
                    command.Parameters.Add("@clientId", SqlDbType.Int).Value = account.Client.Id;

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Account
                                            set AccountName = @accountName, 
                                                IBAN = @iban, 
                                                OverdraftLimit = @overdraftLimit
                                            where AccountId = @accountId";
                    
                    command.Parameters.Add("@accountName", SqlDbType.NVarChar).Value = account.AccountName;
                    command.Parameters.Add("@iban", SqlDbType.VarChar).Value = account.Iban;
                    command.Parameters.Add("@overdraftLimit", SqlDbType.Decimal).Value = account.OverdraftLimit;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = account.Id;

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vracia ucty s udajmi pre datagrid
        /// </summary>
        /// <returns></returns>
        public List<AccountView> GetAccountsForView()
        {

            List<AccountView> accounts = new List<AccountView>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
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
                            AccountView account = new AccountView();
                            account.AccountId = reader.GetInt32(0);
                            account.AccountName = reader.GetString(2);
                            account.Iban = reader.GetString(3);
                            account.EstablishDate = reader.GetDateTime(4);
                            account.CancelDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);
                            account.AccountBalance = reader.GetDecimal(6);
                            account.OverdraftLimit = reader.GetDecimal(7);
                            account.AmmountOfOverdraft = reader.GetDecimal(8);
                            account.CardsCount = reader.GetInt32(9);
                            account.ClientName = reader.GetString(11);
                            account.ClientSurname = reader.GetString(12);
                            account.OpNumber = reader.GetString(13);
                            account.ClientContact = reader.GetString(17);
                            accounts.Add(account);
                        }
                    }
                }
            }
            return accounts;
        }

        /// <summary>
        /// Metoda, ktora vracia ucet pre strucny prehlad 
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<AccountView> GetAccountForShortView(int accountId)
        {

            AccountView account = new AccountView();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Account as a inner join Client as c on a.ClientId = c.ClientId where AccountId = @accountId ";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account.Iban = reader.GetString(3);
                            account.EstablishDate = reader.GetDateTime(4);
                            account.CancelDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);
                            account.AccountBalance = reader.GetDecimal(6);
                            account.OverdraftLimit = reader.GetDecimal(7);
                            account.AmmountOfOverdraft = reader.GetDecimal(8);
                            account.ClientName = reader.GetString(11);
                            account.ClientSurname = reader.GetString(12);
                        }
                    }
                }
            }
            List<AccountView> accounts = new List<AccountView>();
            accounts.Add(account);

            return accounts;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy ofiltrovane udaje udaje podla filtra v parametroch
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<AccountView> GetFilteredAccountsForView(string filter)
        {
            List<AccountView> accounts = new List<AccountView>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = @"Select * 
                                            from Account as a   
                                            inner join Client as c 
                                            on a.ClientId = c.ClientId
                                            where (c.Surname like @surname OR a.IBAN like @iban)";
                    command.Connection = connection;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = $"%{filter}%";
                    command.Parameters.Add("@iban", SqlDbType.NVarChar).Value = $"%{filter}%";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AccountView account = new AccountView();
                            account.AccountName = reader.GetString(2);
                            account.Iban = reader.GetString(3);
                            account.EstablishDate = reader.GetDateTime(4);
                            account.CancelDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);
                            account.AccountBalance = reader.GetDecimal(6);
                            account.OverdraftLimit = reader.GetDecimal(7);
                            account.AmmountOfOverdraft = reader.GetDecimal(8);
                            account.CardsCount = reader.GetInt32(9);
                            account.ClientName = reader.GetString(11);
                            account.ClientSurname = reader.GetString(12);
                            account.OpNumber = reader.GetString(13);
                            account.ClientContact = reader.GetString(17);
                            accounts.Add(account);
                        }
                    }
                }
            }
            return accounts;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy ucet podla Id
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public Account GetAccountById(int accountId)
        {
            Account account = new Account();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Account as a inner join Client as c on a.ClientId = c.ClientId where AccountId = @accountId ";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account.Id = accountId;
                            account.AccountName = reader.GetString(2);
                            account.Iban = reader.GetString(3);
                            account.EstablishDate = reader.GetDateTime(4);
                            account.CancelDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);
                            account.AccountBalance = reader.GetDecimal(6);
                            account.OverdraftLimit = reader.GetDecimal(7);
                            account.AmmountOfOverdraft = reader.GetDecimal(8);
                            account.CardsCount = reader.GetInt32(9);
                            account.Client.Id = reader.GetInt32(10);
                            account.Client.Name = reader.GetString(11);
                            account.Client.Surname = reader.GetString(12);
                            account.Client.OpNumber = reader.GetString(13);
                            account.Client.Street = reader.GetString(14);
                            account.Client.StreetNumber = reader.GetString(15);
                            account.Client.City = reader.GetString(16);
                            account.Client.Contact = reader.GetString(17);
                        }
                    }
                }
            }
            return account;
        }

        /// <summary>
        /// Metoda, ktora zrusi ucet
        /// </summary>
        /// <param name="accountId"></param>
        public void CloseAccount(int accountId)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"update Account
                                            set CancelDate = Getdate() 
                                            where AccountId = @accountId";

                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Metoda ktora vrati z databazy ofiltrovane ucty 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Account> GetFilteredAccounts(string filter)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = @"Select *
                                            from Account as a   
                                            inner join Client as c 
                                            on a.ClientId = c.ClientId
                                            where (c.Surname = @surname OR a.IBAN = @iban OR c.OpNumber = @opNumber)";
                    command.Connection = connection;
                    command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = filter;
                    command.Parameters.Add("@iban", SqlDbType.NVarChar).Value = filter;
                    command.Parameters.Add("@opNumber", SqlDbType.NVarChar).Value = filter;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account account = new Account();
                            account.Id = reader.GetInt32(0);
                            //account.AccountName = reader.GetString(2);
                            //account.Iban = reader.GetString(3);
                            //account.EstablishDate = reader.GetDateTime(4);
                            //account.CancelDate = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5);
                            //account.AccountBalance = reader.GetDecimal(6);
                            //account.OverdraftLimit = reader.GetDecimal(7);
                            //account.AmmountOfOverdraft = reader.GetDecimal(8);
                            //account.CardsCount = reader.GetInt32(9);
                            //account.ClientName = reader.GetString(11);
                            //account.ClientSurname = reader.GetString(12);
                            //account.OpNumber = reader.GetString(13);
                            //account.ClientContact = reader.GetString(17);
                            accounts.Add(account);
                        }
                    }
                }
            }

            return accounts;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy Id uctu podla cisla karty
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public int GetAccountIdByCardNumber(int cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Select a.AccountId
                                            from Account as a
                                            inner join AccountCard as ac
                                            on a.AccountId = ac.AccountId
                                            inner join Card as c
                                            on c.CardId  = ac.CardId
                                            where CardNumber = @cardNumber";

                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    return (int)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy zostatok uctu podla cila karty
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns></returns>
        public decimal GetAccounBalanceByCardNumber(int cardNumber)
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Select a.AccountBalance
                                            from Account as a
                                            inner join AccountCard as ac
                                            on a.AccountId = ac.AccountId
                                            inner join Card as c
                                            on c.CardId  = ac.CardId
                                            where CardNumber = @cardNumber";

                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;

                    return (decimal)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Metoda, ktora ziska udaje pre prehlad zalozenych uctov po mesiacoch
        /// </summary>
        /// <returns></returns>
        public DataSet GetEstablAccountsMonthly()
        {
            SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING);
            string command = @"select count(*) as 'Count of established accounts', (datename(month, (EstablishDate))) as Month
                               from Account
                               where EstablishDate between dateadd(month,-6, GETDATE()) and  GETDATE()
                               group by (datename(month, (EstablishDate)))
                               order by count(*) desc";

            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
            {
                adapter.Fill(ds, "EstablishedAccounts");
            }
            return ds;
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy pocet aktivnych uctov
        /// </summary>
        /// <returns></returns>
        public int GetActiveAccountsCount()
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"select count(*) from account where CancelDate is null";
                                        
                    return (int)command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati z databazy udaj pre prehlad o prostriedkoch klientov banky
        /// </summary>
        /// <returns></returns>
        public decimal GetFunds()
        {
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"select sum(AccountBalance) from account";

                    return (decimal)command.ExecuteScalar();
                }
            }
        }


    }
}
