using System;
using System.Collections.Generic;

namespace InterfaceGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> listeVoiture = new List<Voiture>();
            Console.WriteLine("Hello World!");
            Voiture v1 = new Voiture("Grise", "Ford", 250);
            Voiture v2 = new Voiture("Grise", "Peugeot", 20);
            Voiture v3 = new Voiture("Grise", "GMD", 200);
            Voiture v4 = new Voiture("Grise", "Toyota", 100);
            Voiture v5 = new Voiture("Grise", "BMW", 150);
            Voiture v6 = new Voiture("Grise", "Nissan", 240);
            Voiture v7 = new Voiture("Grise", "Hunday", 350);
            Voiture v8 = new Voiture("Grise", "Chrevolet", 50);
            //ajout des voitures dans la liste
            listeVoiture.Add(v1);
            listeVoiture.Add(v2);
            listeVoiture.Add(v3);
            listeVoiture.Add(v4);
            listeVoiture.Add(v5);
            listeVoiture.Add(v6);
            listeVoiture.Add(v7);
            listeVoiture.Add(v8);
            //on trie la liste des voitures sur la vitesse
            listeVoiture.Sort();
            //affichage de la liste des voitures dans la parking
            foreach (Voiture v in listeVoiture)
            {
                Console.WriteLine(v.ToString());
            }
            //la partie des personnes
            List<Personne<string, int, double>> listePersonne1 = new List<Personne<string, int, double>>();
            List<Personne<string, double, double>> listePersonne2 = new List<Personne<string, double, double>>();
            List<Personne<string, int, int>> listePersonne3 = new List<Personne<string, int, int>>();
            //creation des personnes
            Personne<string, int, int> person1 = new Personne<string, int, int>("Paul", "Faye", 36, 60000);
            Personne<string, int, int> person4 = new Personne<string, int, int>("Jacques", "Faye", 36, 40000);

            Personne<string, int, double> person2 = new Personne<string, int, double>("Sophie", "Faye", 39, 80000);
            Personne<string, double, double> person3 = new Personne<string, double, double>("Sophie", "Faye", 39, 80000);
            listePersonne1.Add(person2);
            listePersonne2.Add(person3);
            listePersonne3.Add(person1);
            listePersonne3.Add( person4);
           // listePersonne3.Sort();
            foreach(Personne<string,int,int> v in listePersonne3)
            {
                Console.WriteLine(v.ToString());
            }
        }
} 
}

  
