using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    public class FrmClientManagementViewModel
    {
        private AccountRepository _accountRepository;
        private CardRepository _cardRepository;

        public FrmClientManagementViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            CardRepository cardRepository = new CardRepository();
            _accountRepository = accountRepository;
            _cardRepository = cardRepository;
        }

        public List <AccountView> GetAccountByID(int accountId)
        {
            return _accountRepository.GetAccountForShortView(accountId);   
        }

        public void AddNewCard(int accountId)
        {
            Card card = AccountFactory.CreateCard();
            _cardRepository.AddNewCard(card, accountId);
        }

        public List<Card> GetCards(int accountId)
        {
            return _cardRepository.GetCardsByAccountId(accountId);
        }

        public void CloseAccount(int accountId)
        {
            _accountRepository.CloseAccount(accountId);

        }

        public bool IsAccountOpen(int accountId)
        {
            Account account = _accountRepository.GetAccountById(accountId);
            if (account.CancelDate == DateTime.MinValue)
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
