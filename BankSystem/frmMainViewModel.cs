using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    public class FrmMainViewModel
    {
        private AccountRepository _accountRepository;

        public FrmMainViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;
        }

        public List<Account> FindClients(string filter)
        {
            return _accountRepository.GetFilteredAccounts(filter);
        }
    }
}
