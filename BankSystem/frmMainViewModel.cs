using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;
using System.Data;

namespace BankSystem
{
    /// <summary>
    /// Pomocna trieda za formularom, ktora z neho zbiera data a posiela mu data z databazy
    /// </summary>
    public class FrmMainViewModel
    {
        private AccountRepository _accountRepository;
        private ClientRepository _clientRepository;

        public FrmMainViewModel()
        {
            AccountRepository accountRepository = new AccountRepository();
            _accountRepository = accountRepository;

            ClientRepository clientRepository = new ClientRepository();
            _clientRepository = clientRepository;
        }

        public List<Account> FindClients(string filter)
        {
            return _accountRepository.GetFilteredAccounts(filter);
        }

        public DataSet GetTopClients()
        {
            return _clientRepository.GetTopClients();
        }

        public DataSet GetDemography()
        {
            return _clientRepository.GetDemography();
        }

        public int GetActiveAccountsCount()
        {
            return _accountRepository.GetActiveAccountsCount();
        }

        public decimal GetFunds()
        {
            return _accountRepository.GetFunds();
        }

        public DataSet GetEstablAccountsMonthly()
        {
            return _accountRepository.GetEstablAccountsMonthly();
        }
    }
}
