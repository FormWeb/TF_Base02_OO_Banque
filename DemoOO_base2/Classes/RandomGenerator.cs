using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO_base2.Classes
{
    internal static class RandomGenerator
    {  
        private static Random _random = new Random();

        public static int rollDice(int maxValue)
        {
            return _random.Next(1, maxValue+1);
        }
    }
}
