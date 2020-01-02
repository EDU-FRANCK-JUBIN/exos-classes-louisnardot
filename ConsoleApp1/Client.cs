using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Client
    {
        private int CNI;
        private String nom;
        private String prenom;
        private String tel;

        public Client(int cni, string nom, string prenom)
        {
            CNI = cni;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Client(int cni, string nom, string prenom, string tel)
        {
            this.CNI = cni;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public int Cni { get => CNI; set => CNI = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }

        public void Afficher()
        {
            Console.WriteLine("Client : " + this.Nom + " " + this.Prenom + " " + this.Tel);
        }
    }
}
