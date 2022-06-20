using DemoOO_base2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classes
{
    class Voiture : Vehicule
    {
        private string _couleur;
        private TypeMoteur _moteur;
        private int _nbrPorte;
        private string _typeChassis;
        public double _prix;

        private int _kmParcouru;

        public int KmParcouru { 
            get {
                return _kmParcouru;
            }
        }


        public Voiture(string name, string couleur, TypeMoteur moteur, int nbrPorte,
            string typeChassis, double prix) : base(name)
        {
            this._couleur = couleur;
            this._moteur = moteur;
            this._nbrPorte = nbrPorte;
            this._typeChassis = typeChassis;
            this._prix = prix;
            this._kmParcouru = 0;
        }

        public Voiture(string couleur, TypeMoteur moteur, int nbrPorte, string typeChassis, double prix, int kmParcouru) : base()
        {
            _couleur = couleur;
            _moteur = moteur;
            _nbrPorte = nbrPorte;
            _typeChassis = typeChassis;
            _prix = prix;
            _kmParcouru = kmParcouru;
        }

        public void SeDeplacer()
        {
            Console.WriteLine("Je me deplace.");
            _kmParcouru += 20;
        }


        public double GetPrix()
        {
            return _prix;
        }

        protected void SetPrix(double prix)
        {
            if (prix > 0)
                _prix = prix;
        }

        private double _prix2;

        public double Prix2
        {
            get { return _prix2; }
            set { 
                if( value > 0 )
                    _prix2 = value; 
            }
        }



        public int Prix3 { get; protected set; }

        public void RePeindre(string nouvelleCouleur)
        {
            _couleur = nouvelleCouleur;
        }

        public override void Rouler()
        {
            Console.WriteLine("Vroum");
        }

    }

    enum TypeMoteur
    {
        GAZ,
        ELEC,
        ESSENCE,
        DIESEL,
        HYDROGEN
    }
}
