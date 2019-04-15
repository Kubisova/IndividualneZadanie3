using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;

namespace BankSystem
{
    public class FrmAccountViewModel
    {
        public string AccountName { get; set; }
        public string Iban { get; set; }
        public decimal OverdraftLimit { get; set; }
        public int CardsCount { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string OpNumber { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }

        public Account Account { get; set; }
        public bool IsEdit { get; set; }

        private AccountRepository _accountRepository;

        public FrmAccountViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public void AddAccount()
        {
            Client client = new Client();
            client.Name = Name;
            client.Surname = Surname;
            client.OpNumber = OpNumber;
            client.Street = Street;
            client.StreetNumber = StreetNumber;
            client.City = City;
            client.Contact = Contact;

            Account account = AccountFactory.CreateAccount(AccountName, Iban, OverdraftLimit, CardsCount, client);
            _accountRepository.AddAccount(account);
        }

        public void EditAccount()
        {
            Account.AccountName = AccountName;
            Account.Iban = Iban;
            Account.OverdraftLimit = OverdraftLimit;
            Account.CardsCount = CardsCount;
            Account.Client.Name = Name;
            Account.Client.Surname = Surname;
            Account.Client.OpNumber = OpNumber;
            Account.Client.Street = Street;
            Account.Client.StreetNumber = StreetNumber;
            Account.Client.City = City;
            Account.Client.Contact = Contact;

            _accountRepository.EditAccount(Account);
        }

        public void GetAccountById(int accountId)
        {
            Account = _accountRepository.GetAccountById(accountId);
        }
    }
}
