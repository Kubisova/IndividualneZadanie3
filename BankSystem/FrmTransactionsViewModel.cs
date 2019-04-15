using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
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
