using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Compte
    {
        private Client proprietaire;
        private double solde;
        private readonly int numero;
        public static int nbCompte;

        public Compte(Client proprietaire)
        {
            this.proprietaire = proprietaire;
            numero = ++nbCompte;
        }

        public Compte(Client proprietaire, Double solde)
        {
            this.proprietaire = proprietaire;
            this.solde = solde;
            numero = ++nbCompte;
        }

        public double Solde { get => solde; }
        internal Client Proprietaire { get => proprietaire; set => proprietaire = value; }

        public void Crediter(double somme)
        {
            this.solde += somme;
        }

        public void Crediter(double somme, Compte compte)
        {
            this.solde += somme;
            compte.solde -= somme;
        }

        public void Debiter(double somme)
        {
            this.solde -= somme;
        }

        public void Debiter(double somme, Compte compte)
        {
            this.solde -= somme;
            compte.solde += somme;
        }

        public void AfficherInfos()
        {
            Console.WriteLine("Le propriétaire du compte est : " + this.proprietaire.Prenom + " " + this.proprietaire.Nom + " n°" + numero + " solde : " + Solde + " euros");
        }

        public void AfficherNbCompte()
        {
            Console.WriteLine("Nombre de compte créé(s) : " + nbCompte);
        }
    }
}
