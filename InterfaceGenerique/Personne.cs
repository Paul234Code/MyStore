using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceGenerique
{
    public class Personne<T,U,X> where X: IComparable
    {
        public T Prenom { get; set; }
        public T Nom { get; set; }
        public U Age { get; set; }
        public X Salaire { get; set; }

        //le constructeur de la classe
        public Personne(T prenom,T nom, U age, X salaire):base()
        {
            Prenom = prenom;
            Nom = nom;
            Age = age;
            Salaire = salaire;
        }
        //la methode to string
        public override string ToString()
        {
            return "Prenom:" + Prenom + "\nNom: " + Nom +
                  "\nAge:" + Age + "\nSalaire:" + Salaire;
        }




        

        public int CompareTo([AllowNull] Personne<T, U, X> other)
        {
            return Salaire.CompareTo(other.Salaire);
        }
    }
}
