using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;


namespace BankSystem
{
    public class frmAccountsViewModel
    {
        private AccountRepository _accountRepository;

        public frmAccountsViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public List<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
