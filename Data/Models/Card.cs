using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int CardNumber { get; set; }
        public int Pin { get; set; }
        public DateTime CardValidity { get; set; }
        public bool IsBlocked { get; set; }
    }
}
