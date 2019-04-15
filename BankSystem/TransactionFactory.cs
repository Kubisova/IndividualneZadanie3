using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace BankSystem
{
    static class TransactionFactory
    {
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
