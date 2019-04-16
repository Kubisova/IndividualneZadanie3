using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace BankSystem
{
    /// <summary>
    /// staticka trieda na vyrobu transakcii
    /// </summary>
    public static class TransactionFactory
    {
        /// <summary>
        /// Trieda, ktora z udajov v parametroch zostavi a vrati transakciu prevod na iny ucet
        /// </summary>
        /// <param name="ammount"></param>
        /// <param name="accountOfRecipient"></param>
        /// <param name="vs"></param>
        /// <param name="ks"></param>
        /// <param name="ss"></param>
        /// <param name="messageForRecipient"></param>
        /// <returns></returns>
        public static Transaction CreateTransaction(decimal ammount, string accountOfRecipient, int vs, int ks, string ss, string messageForRecipient)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionType = TransactionType.Debet;
            transaction.Ammount = ammount;
            transaction.TransactionDate = DateTime.Now.Date;
            transaction.AccountOfRecipient = accountOfRecipient;
            transaction.Vs = vs;
            transaction.Ss = ss;
            transaction.Ks = ks;
            transaction.MessageForRecipient = messageForRecipient;

            return transaction;
        }

        /// <summary>
        /// Trieda, ktora z udajov v parametroch zostavi a vrati transakcie vyber a vklad
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public static Transaction CreateTransaction(decimal amount, string transactionType)
        {
            Transaction transaction = new Transaction();
            if (transactionType == "deposit")
            {
                transaction.TransactionType = TransactionType.Kredit;
            }
            else if(transactionType =="withdrawal")
            {
                transaction.TransactionType = TransactionType.Debet;
            }
            transaction.Ammount = amount;
            transaction.TransactionDate = DateTime.Now.Date;

            return transaction;
        }
    }
}
