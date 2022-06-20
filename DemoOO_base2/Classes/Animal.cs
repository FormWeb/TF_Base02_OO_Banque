using DemoOO_base2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO_base2.Classes
{
    internal class Animal : ISeNommer, ISeDeplacer
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void SeDeplacer()
        {
            Console.WriteLine("L'animal se déplace");
        }
    }
}
