using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    public class FrmMainViewModel
    {
        private TransactionRepository _transactionRepository;
        private LoginValidator _loginValidator;

        public int CardNumber { get; set; }
        public int Pin { get; set; }

        public FrmMainViewModel()
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            _transactionRepository = transactionRepository;

            LoginValidator loginValidator = new LoginValidator();
            _loginValidator = loginValidator;
        }

        public bool IsCardNumberInDb()
        {
            return _loginValidator.IsCardNumberInDb(CardNumber);
        }

        public bool IsAccountActive()
        {
            return _loginValidator.IsAccountActive(CardNumber);
        }

        public bool IsCardValid()
        {
            return _loginValidator.IsCardValid(CardNumber);
        }

        public bool IsCardBlocked()
        {
            return _loginValidator.IsCardBlocked(CardNumber);
        }

        public bool IsPinValid()
        {
            return _loginValidator.IsPinValid(CardNumber, Pin);
        }

    }
}
