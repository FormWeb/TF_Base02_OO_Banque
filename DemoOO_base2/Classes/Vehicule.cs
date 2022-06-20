using DemoOO_base2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO_base2.Classes
{
    internal abstract class Vehicule : ISeDeplacer, ISeNommer
    {
        public string Name { get; set; }

        public Vehicule()
        {
            this.Name = "";
        }
        
        public Vehicule(string name)
        {
            this.Name = name;
        }

        public abstract void Rouler();

        public void SeDeplacer()
        {
            Console.WriteLine("La voiture se déplace");
        }
    }
}
