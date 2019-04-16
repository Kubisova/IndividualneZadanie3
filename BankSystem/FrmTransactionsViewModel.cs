using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    /// <summary>
    /// Pomocna trieda za formularom, ktora z neho zbiera data a posiela mu data z databazy
    /// </summary>
    public class FrmTransactionsViewModel
    {
        private TransactionRepository _transactionRepository;

        public FrmTransactionsViewModel()
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            _transactionRepository = transactionRepository;
        }

        public List<Transaction> GetTransactions()
        {
            return _transactionRepository.GetTransactions();
        }

        public List<Transaction> GetTransactionsByAccountId(int accountId)
        {
            return _transactionRepository.GetTransactionsByAccountId(accountId);
        }
    }
}
