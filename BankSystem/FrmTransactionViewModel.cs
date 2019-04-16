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
    public class FrmTransactionViewModel
    {
        public decimal Ammount { get; set; }
        public string AccountOfRecipient { get; set; }
        public int Vs { get; set; }
        public string Ss { get; set; }
        public int Ks { get; set; }
        public string MessageForRecipient { get; set; }

        public bool IsDeposit { get; set; }
        public bool IsWithdrawal { get; set; }

        private TransactionRepository _transactionRepository;
        private AccountRepository _accountRepository;

        public FrmTransactionViewModel()
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            _transactionRepository = transactionRepository;

            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public void AddTransaction(int accountId)
        {
            Transaction transaction = new Transaction();
            if (IsDeposit)
            {
                transaction =  TransactionFactory.CreateTransaction(Ammount, $"deposit");
                _transactionRepository.AddDeposit(transaction, accountId);
               
            }
            else if (IsWithdrawal)
            {
                transaction = TransactionFactory.CreateTransaction(Ammount, $"withdrawal");
                _transactionRepository.AddWithdrawal(transaction, accountId);
            }
            else
            {
                transaction = TransactionFactory.CreateTransaction(Ammount, AccountOfRecipient, Vs, Ks, Ss, MessageForRecipient);
                _transactionRepository.AddTransaction(transaction, accountId);
            }
        }

        public string GetSenderAccountByAccounId(int accountId)
        {
            var account = _accountRepository.GetAccountById(accountId);
            return account.Iban;
        }

        public decimal GetAccountBalance(int accountId)
        {
            var account = _accountRepository.GetAccountById(accountId);
            return account.AccountBalance;
        }

        public bool IsNotEnoughMoney(decimal amount, int accountId)
        {
            var account = _accountRepository.GetAccountById(accountId);

            if (account.AccountBalance < amount)
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
