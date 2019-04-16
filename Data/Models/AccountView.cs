using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data.Models
{
    /// <summary>
    /// Trieda, ktora sa pouziva ako podklad pre zobrazenie v gride
    /// </summary>
    public class AccountView
    {
        public int AccountId { get; set; }

        [DisplayName("Account name")]
        public string AccountName { get; set; }

        [DisplayName("IBAN")]
        public string Iban { get; set; }

        [DisplayName("Date of establishment")]
        public DateTime EstablishDate { get; set; }

        [DisplayName("Cancel date")]
        public DateTime CancelDate { get; set; }

        [DisplayName("Account balance")]
        public decimal AccountBalance { get; set; }

        [DisplayName("Overdraft limit")]
        public decimal OverdraftLimit { get; set; }

        [DisplayName("Ammount of overdraft")]
        public decimal AmmountOfOverdraft { get; set; }

        [DisplayName("Cards count")]
        public int CardsCount { get; set; }

        [DisplayName("Name")]
         public string ClientName  { get; set; }

        [DisplayName("Surname")]
        public string ClientSurname  { get; set; }

        [DisplayName("ID card number")]
        public string OpNumber { get; set; }

        [DisplayName("Contact")]
        public string ClientContact { get; set; }



    }
}
