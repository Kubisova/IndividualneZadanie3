using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Trieda ktora reprezentuje ucet v banke, obsahuje v sebe objekty klienta a kariet
    /// </summary>
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Iban { get; set; }
        public DateTime EstablishDate { get; set; }
        public DateTime CancelDate { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal OverdraftLimit { get; set; }
        public decimal AmmountOfOverdraft { get; set; }
        public int CardsCount { get; set; }

        public Client Client { get; set; }

        public List<Card> Cards  { get; set; }

        public Account()
        {
            Client = new Client();
            Cards = new List<Card>();
        }
    }

    
}
