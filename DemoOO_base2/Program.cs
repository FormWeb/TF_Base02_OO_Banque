
using DemoOO.Enfant;
using EE = DemoOO.Enfant.Enfant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoOO.Classes;
using DemoOO_base2.Classes;
using DemoOO_base2.Interfaces;
using DemoOO_base2.Delegate;

namespace DemoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" NAMESPACE ");
            MaClasse m;
            EE.MaClasse m2;
            EE.Final.AutreClass ac;


            Console.WriteLine(" CLASSE ");
            

            Vehicule v3 = new Voiture("Jacqueline", "Rouge", TypeMoteur.GAZ, 5, "Berlin", 10000);

            Voiture v3EnVoiture = (Voiture)v3;

            v3EnVoiture.Rouler();
            v3EnVoiture.RePeindre("rouge");

            Console.WriteLine(RandomGenerator.rollDice(6));

            ISeDeplacer v3QuiSeDeplace = v3;

            Animal a1 = new Animal("Titi");

            // Exemple exception

            try
            {
                int x = 0;
                int y = 2;
                Console.WriteLine(y / x);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                // Autre exception
            }
            finally
            {
                Console.WriteLine("Executer quoi qu'il arrive");
            }

            Console.WriteLine("Fin programme");
            

            Console.WriteLine("Insérez un mot qui ne contient pas de 'e'");

            string mot = Console.ReadLine();

            try
            {
                if (mot.Contains("e"))
                {
                    throw new ContientEException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Exemple Delegate

            MakeMath del = null;
            del += Addition;
            del += Soustraction;
            del += Multiplication;
            del += Multiplication;
            del += delegate (int x, int y)
            {
                Console.WriteLine((double)x / y);
            };

            del += (x, y) =>
            {
                Console.WriteLine((double)x/y);
            };

            del(5, 8);


            //v.KmParcouru = 50;
        }

        public static void Addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Soustraction(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public static void Multiplication(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }

    
}

