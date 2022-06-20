using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Epargne : Compte
    {
        

        #region Propriétés
        public DateTime DateDernierRetrait { get; private set; }
        #endregion

        #region Constructeurs
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, decimal solde, Personne titulaire) : base(numero, solde, titulaire)
        {
        }


        #endregion

        #region Méthodes
        public void Retrait(decimal montant)
        {
            decimal oldSolde = Solde;
            base.Retrait(montant);

            if(oldSolde != Solde)
                DateDernierRetrait = DateTime.Now;
        }

        protected override decimal CalculInteret()
        {
            return Solde * 0.045M;
        }
        #endregion
    }
}
