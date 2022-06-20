using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialisation des elements");
            DateTime dt = new DateTime(1990, 1, 1);
            Personne p = new Personne("Luc", "Dubois", dt);
            Courant c = new Courant( "BE02...", p, -100 );

            // Opération sur le compte courant (Sodle 0)
            Console.WriteLine($"Initial : {c.Numero} - Solde: {c.Solde}");

            // - Retrait de 100€
            c.Retrait(100);
            Console.WriteLine($"Retrait de 100 : {c.Numero} - Solde: {c.Solde}");

            // - Depot de 100€
            c.Depot(100);
            Console.WriteLine($"Depot de 100 : {c.Numero} - Solde: {c.Solde}");

            // - Mauvais dépot
            // c.Depot(-100);
            try
            {
                c.Depot(-100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            // - Retrait de 200€. Refusé => Ligne de credit !
            try
            {
                c.Retrait(-200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                c.Retrait(200);
            }
            catch (SoldeInsuffisantException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Value);
            }
            
            
            Console.WriteLine($"Retrait de 200 : {c.Numero} - Solde: {c.Solde} (Refusé)");

            // Test banque

            Banque b = new Banque("Piscou & co");

            b.Ajouter(c);

            // Exemple polymorphisme

            Compte e1 = new Epargne("BE10...", p);
            e1.AppliquerInteret();
            b.Ajouter(e1);


            foreach(Compte compte in b.Comptes.Values)
            {
                Console.WriteLine(compte.Numero);
            }

            Console.WriteLine(Banque.COUNTRY_CODE);

            // Utilisation interface

            Compte c3 = new Epargne("BE55...", p);
       

            Console.ReadLine();
        }
    }
}
