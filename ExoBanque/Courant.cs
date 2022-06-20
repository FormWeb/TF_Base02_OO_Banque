using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    internal class Courant : Compte
    {
        #region Champs
        private decimal _LigneDeCredit;

        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
            _LigneDeCredit = 0;
        }

        public Courant(string numero, decimal solde, Personne titulaire) : base(numero, solde, titulaire)
        {
            _LigneDeCredit = 0;
        }

        public Courant(string numero, Personne titulaire, decimal ligneDeCredit) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }


        #endregion

        #region Propriétés
        public decimal LigneDeCredit
        {
            get { return _LigneDeCredit; }
            private set {
                if (value < 0)
                {
                    throw new InvalidOperationException();
                }
                _LigneDeCredit = value;
            }
        }
        #endregion

        #region Constructeurs

        
        
        #endregion

        #region Méthodes
        public override void Retrait(decimal montant)
        {
            Retrait(montant, LigneDeCredit);
        }

        protected override decimal CalculInteret()
        {
            return (Solde > 0) ? Solde * 0.03M : Solde * 0.0975M;
        }
        #endregion
    }
}
