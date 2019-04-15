using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    public class LoginValidator
    {
        private CardRepository _cardRepository;
        private int _tryCounter = 1;
        const int TryCount = 3;
        private int _cardNumber; 

        public LoginValidator()
        {
            CardRepository cardRepository = new CardRepository();
            _cardRepository = cardRepository;
        }

        public bool IsAccountActive(int cardNumber)
        {
            if (_cardRepository.GetAccountCancelDate(cardNumber) == DateTime.MinValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCardNumberInDb(int cardNumber)
        {
            if (_cardRepository.GetPinByCardNumber(cardNumber) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsCardValid(int cardNumber)
        {
            if (_cardRepository.GetCardValidityDate(cardNumber) > DateTime.Now.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCardBlocked(int cardNumber)
        {
            if (_cardRepository.IsCardBlocked(cardNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPinValid(int cardNumber, int pin)
        {
            if (cardNumber !=_cardNumber )
            {
                _tryCounter = 1;
                _cardNumber = cardNumber;
            }

            if (_cardRepository.GetPinByCardNumber(cardNumber) == pin)
            {
                _tryCounter = 1;
                return true;
            }
            else
            {
                if (_tryCounter < TryCount)
                {
                    _tryCounter++;
                }
                else
                {
                    _cardRepository.SetCardAsBlocked(cardNumber);
                }
                return false;
            }
        }
    }
}
