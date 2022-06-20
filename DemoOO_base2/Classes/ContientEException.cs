using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO_base2.Classes
{
    internal class ContientEException : ArgumentException
    {
        public ContientEException() : base("Le mot contient un e")
        {

        }
    }
}
