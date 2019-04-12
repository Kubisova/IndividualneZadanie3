using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Account
    {
        public int Id { get; set; }
        //public int ClientId { get; set; }
        public string Iban { get; set; }
        public DateTime EstablishDate { get; set; }
        public DateTime CancelDate { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal OverdraftLimit { get; set; }
        public decimal AmmountOfOverdraft { get; set; }
        public Client client { get; set; }

    }
}
