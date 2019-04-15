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
    public class TransactionRepository
    {
        public string connectionString = @"Server = DESKTOP-GKFDQEI\SQLEXPRESS; Database = TransformerbankDb;Trusted_Connection = true";

        public void AddTransaction(Transaction transaction, int accountId)
        {
            //bool success;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into [Transaction] 
                                            values(@transactionType, @accountId, @amount, @date, @accountOfRecipient, @vs,@ss, @ks, @message)";

                    command.Parameters.Add("@transactionType", SqlDbType.Int).Value =  (int)transaction.TransactionType;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = transaction.TransactionDate;
                    command.Parameters.Add("@accountOfRecipient", SqlDbType.VarChar).Value = transaction.AccountOfRecipient;
                    command.Parameters.Add("@vs", SqlDbType.Int).Value = transaction.Vs;
                    command.Parameters.Add("@ss", SqlDbType.VarChar).Value = transaction.Ss;
                    command.Parameters.Add("@ks", SqlDbType.Int).Value = transaction.Ks;
                    command.Parameters.Add("@message", SqlDbType.VarChar).Value = transaction.MessageForRecipient;

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Update Account set AccountBalance = (AccountBalance - @amount) where AccountId = @accountId";
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddDeposit(Transaction transaction, int accountId)
        {
            //bool success;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into [Transaction] (TransactionType, AccountId, Amount, date)
                                            values(@transactionType, @accountId, @amount, @date)";

                    command.Parameters.Add("@transactionType", SqlDbType.Int).Value = (int)transaction.TransactionType;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = transaction.TransactionDate;

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Update Account set AccountBalance = (AccountBalance + @amount) where AccountId = @accountId";
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddWithdrawal(Transaction transaction, int accountId)
        {
            //bool success;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"insert into [Transaction] (TransactionType, AccountId, Amount, date)
                                            values(@transactionType, @accountId, @amount, @date)";

                    command.Parameters.Add("@transactionType", SqlDbType.Int).Value = (int)transaction.TransactionType;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = transaction.TransactionDate;

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Update Account set AccountBalance = (AccountBalance - @amount) where AccountId = @accountId";
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Ammount;
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from [Transaction]";
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction();
                            transaction.Id = reader.GetInt32(0);
                            transaction.TransactionType = (TransactionType)reader.GetInt32(1);
                            transaction.Ammount = reader.GetDecimal(3);
                            transaction.TransactionDate = reader.GetDateTime(4);
                            transaction.AccountOfRecipient = reader.IsDBNull(5)?"": reader.GetString(5);
                            transaction.Vs = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                            transaction.Ss = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            transaction.Ks = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                            transaction.MessageForRecipient = reader.IsDBNull(9) ? "" : reader.GetString(9);


                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetTransactionsByAccountId(int accountId)
        {
            List<Transaction> transactions = new List<Transaction>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from [Transaction] where AccountId = @accountId";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction();
                            transaction.Id = reader.GetInt32(0);
                            transaction.TransactionType = (TransactionType)reader.GetInt32(1);
                            transaction.Ammount = reader.GetDecimal(3);
                            transaction.TransactionDate = reader.GetDateTime(4);
                            transaction.AccountOfRecipient = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            transaction.Vs = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                            transaction.Ss = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            transaction.Ks = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                            transaction.MessageForRecipient = reader.IsDBNull(9) ? "" : reader.GetString(9);


                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetTransactionsByAccountId(int accountId, string orderBy)
        {
            List<Transaction> transactions = new List<Transaction>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from [Transaction] where AccountId = @accountId order by @orderBy";
                    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                    //command.Parameters.Add("@orderBy", ).Value = orderBy;
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction();
                            transaction.Id = reader.GetInt32(0);
                            transaction.TransactionType = (TransactionType)reader.GetInt32(1);
                            transaction.Ammount = reader.GetDecimal(3);
                            transaction.TransactionDate = reader.GetDateTime(4);
                            transaction.AccountOfRecipient = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            transaction.Vs = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                            transaction.Ss = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            transaction.Ks = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                            transaction.MessageForRecipient = reader.IsDBNull(9) ? "" : reader.GetString(9);


                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }
    }
}
