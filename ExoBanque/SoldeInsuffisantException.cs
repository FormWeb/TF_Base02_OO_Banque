using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class SoldeInsuffisantException : Exception
    {
        public decimal Value { get; set; }
        public SoldeInsuffisantException() : base("Solde insuffisant !")
        {
        }
    }
}
