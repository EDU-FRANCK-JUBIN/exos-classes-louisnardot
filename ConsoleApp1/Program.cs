using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1
            Console.WriteLine("Exercice 1 :");
            CompteBancaire unCompte = new CompteBancaire("Louis", 500, "euros", 1);
            Console.WriteLine(unCompte.Decrire());
            unCompte.Crediter(30.5);
            Console.WriteLine(unCompte.Decrire());
            unCompte.Debiter(80);
            Console.WriteLine(unCompte.Decrire());

            // Exercice 2
            Console.WriteLine("");
            Console.WriteLine("Exercice 2 :");
            Client client1 = new Client(452897529, "NARDOT", "Louis", "0652437892");
            Compte compte1 = new Compte(client1);
            Compte compte2 = new Compte(client1);

            //Créditer le compte 1 avec 500€
            Console.WriteLine("Credit du compte 1 de 500e");
            compte1.Crediter(500);
            compte1.AfficherInfos();

            //Créditer le compte 2 avec 200 euros
            Console.WriteLine("Credit du compte 2 de 200e");
            compte2.Crediter(200);
            compte2.AfficherInfos();

            //Transfert
            Console.WriteLine("Transfert de 50e du compte 1 vers le compte 2");
            compte2.Crediter(50, compte1);
            compte1.AfficherInfos();
            compte2.AfficherInfos();

            // Exo 3
            Console.WriteLine("");
            Console.WriteLine("Exercice 3 :");
            testArticle();
        }


        static void testArticle()
        {
            Article test1 = new Article();
            Article test2 = new Article(reference: "012345", designation: "Board element");
            Article test3 = new Article(reference: "012346", designation: "Roues bones", prixHT: 50.0, tauxTVA: 20);
            Article test4 = new Article(test3);

            test1.AfficherArticle();
            test2.AfficherArticle();
            test3.AfficherArticle();
            test4.AfficherArticle();
        }

    }

}

