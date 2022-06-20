using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    class Banque
    {
        public static readonly string COUNTRY_CODE = "BE";

        #region Champs
        // Dico avec en clef "numero de compte" et en valeur "le compte"
        public Dictionary<string, Compte> Comptes { get; set; }
        #endregion

        #region Props
        public string Nom { get; set; }
        #endregion

        #region Ctor
        public Banque(string nom)
        {
            this.Nom = nom;

            // Initialisation du dico des comptes
            this.Comptes = new Dictionary<string, Compte>();
        }
        #endregion

        public void Ajouter(Compte compte)
        {
            string numero = compte.Numero;

            if(Comptes.ContainsKey(numero))
            {
                // Le compte existe deja :o
                return; // -> A remplacer par une erreur
            }
            Comptes.Add(numero, compte);
        }
    }
}
