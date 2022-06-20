using System;

namespace ExoBanque
{
    internal abstract class Compte : ICustomer, IBanker
    {
        public string Numero { get; private set; }
        public decimal Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        protected Compte(string numero, decimal solde, Personne titulaire) : this(numero, titulaire)
        {
            Solde = solde;
        }

        public void Depot(decimal montant)
        {
            if (montant <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Solde += montant;
        }

        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(decimal montant, decimal ligneDeCredit)
        {
            if (montant <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Solde - montant < -ligneDeCredit)
            {

                SoldeInsuffisantException ex = new SoldeInsuffisantException();
                ex.Value = montant;

                throw ex;
            }

            Solde -= montant;
        }

        protected abstract decimal CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
    }
}