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
    /// Staticka trieda, ktora vyraba a vracia ucty
    /// </summary>
    public static class AccountFactory
    {
        /// <summary>
        /// Metoda, ktora zostavi a vrati ucet s nastavenym klientom
        /// </summary>
        /// <returns></returns>
        public static Account CreateAccount()
        {
            Account account = new Account();
            Client client = new Client();
            account.Client = client;

            return account;
        }

        /// <summary>
        /// Metoda, ktora vytvori a vrati ucet aj s objektom klient a kartami
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="iban"></param>
        /// <param name="overdraftLimit"></param>
        /// <param name="cardsCount"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static Account CreateAccount(string accountName,string iban, decimal overdraftLimit, int cardsCount, Client client)
        {
            Account account = new Account();
            account.AccountName = accountName;
            account.Iban = iban;
            account.EstablishDate = DateTime.Now.Date;
            account.OverdraftLimit = overdraftLimit;
            account.CardsCount = cardsCount;

            account.Client = client;
            account.Cards = CreateCards(cardsCount);

            return account;
        }

        /// <summary>
        /// Metoda, ktora vyrobi karty pre metodu, kotra vyraba ucty
        /// </summary>
        /// <param name="cardsCount"></param>
        /// <returns></returns>
        public static List<Card> CreateCards(int cardsCount)
        {
            CardRepository cardRepository = new CardRepository();
            List<Card> cards = new List<Card>();

            int lastIssuedCardNumber = cardRepository.GetLastIssuedCardNumber();
            if (lastIssuedCardNumber == 0)
            {
                lastIssuedCardNumber = 11111;
            }

            int lastCardPin = cardRepository.GetLastIssuedCardPin();
            if (lastCardPin == 0)
            {
                lastCardPin = 1111;
            }

            for (int i = 0; i < cardsCount; i++)
            {
                Card card = new Card();
                card.CardNumber = ++lastIssuedCardNumber;
                card.Pin = ++lastCardPin;
                card.CardValidity = DateTime.Now.Date.AddYears(2);
                card.IsBlocked = false;
                cards.Add(card);
            }
            return cards;
        }

        /// <summary>
        /// Metoda, ktora vyrobi len jednu kartu
        /// </summary>
        /// <returns></returns>
        public static Card CreateCard()
        {
            CardRepository cardRepository = new CardRepository();

            int lastIssuedCardNumber = cardRepository.GetLastIssuedCardNumber();
            if (lastIssuedCardNumber == 0)
            {
                lastIssuedCardNumber = 11111;
            }

            int lastCardPin = cardRepository.GetLastIssuedCardPin();
            if (lastCardPin == 0)
            {
                lastCardPin = 1111;
            }
                Card card = new Card();
                card.CardNumber = ++lastIssuedCardNumber;
                card.Pin = ++lastCardPin;
                card.CardValidity = DateTime.Now.Date.AddYears(2);
                card.IsBlocked = false;
            
            return card;
        }


    }
}
