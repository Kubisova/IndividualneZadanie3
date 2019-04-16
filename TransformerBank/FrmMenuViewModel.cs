using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    /// <summary>
    /// Pomocna trieda za formularom, ktora z neho zbiera data a posiela mu data z databazy
    /// </summary>
    public class FrmMenuViewModel
    {
        public decimal Amount { get; set; }
        private int _cardNumber;

        private TransactionRepository _transactionRepository;
        private AccountRepository _accountRepository;

        public FrmMenuViewModel(int cardNumber)
        {
            _cardNumber = cardNumber;
            TransactionRepository transactionRepository = new TransactionRepository();
            _transactionRepository = transactionRepository;
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public void AddWithdrawal()
        {
            Transaction transaction = CreateTransaction(Amount);
            int accountId = _accountRepository.GetAccountIdByCardNumber(_cardNumber);
            _transactionRepository.AddWithdrawal(transaction, accountId);
        }

        public Transaction CreateTransaction(decimal amount)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionType = TransactionType.Debet;
            transaction.Ammount = amount;
            transaction.TransactionDate = DateTime.Now.Date;

            return transaction;
        }

        public string GetAccounBalance()
        {
            return _accountRepository.GetAccounBalanceByCardNumber(_cardNumber).ToString();
        }

        public bool IsNotEnoughMoney()
        {
            decimal accountBalance = _accountRepository.GetAccounBalanceByCardNumber(_cardNumber);

            if (accountBalance < Amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
