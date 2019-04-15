using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data.Models
{
    public enum TransactionType
    {
        Kredit = 1, Debet = 2
    }

    public class Transaction
    {
        public int Id { get; set; }

        [DisplayName("Transaction type")]
        public TransactionType TransactionType { get; set; }

        [DisplayName("Amount")]
        public decimal Ammount { get; set; }

        [DisplayName("Date of transaction")]
        public DateTime TransactionDate { get; set; }

        [DisplayName("Recipient account")]
        public string AccountOfRecipient { get; set; }

        [DisplayName("Variable symbol")]
        public int Vs { get; set; }

        [DisplayName("Specific symbol")]
        public string Ss { get; set; }

        [DisplayName("Konstant symbol ")]
        public int Ks { get; set; }

        [DisplayName("Message for recipient")]
        public string MessageForRecipient { get; set; }
    }
}
