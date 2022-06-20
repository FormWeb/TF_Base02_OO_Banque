using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal interface ICustomer
    {
        decimal Solde { get; }
        void Depot(decimal montant);
        void Retrait(decimal montant);
    }
}
