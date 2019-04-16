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
    public class FrmAccountsViewModel
    {
        private AccountRepository _accountRepository;
        private List<AccountView> _loadedAccounts;

        public FrmAccountsViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public List<AccountView> GetAccounts()
        {
            _loadedAccounts = _accountRepository.GetAccountsForView();
            return _loadedAccounts;
        }

        public List<AccountView> GetFilteredAccounts(string filter)
        {
            _loadedAccounts = _accountRepository.GetFilteredAccountsForView(filter);
            return _loadedAccounts;
        }

        public int GetAccountId(int index)
        {
            return _loadedAccounts[index].AccountId;
        }
    }
}
