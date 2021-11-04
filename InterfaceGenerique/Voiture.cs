using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceGenerique
{
    public class Voiture:IComparable<Voiture>
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }
        //le constructeur de la classe
        public Voiture(string Couleur,string Marque,int Vitesse)
        {
            this.Couleur = Couleur;
            this.Marque = Marque;
            this.Vitesse = Vitesse;
        }

        public int CompareTo( Voiture other)
        {
            return Vitesse.CompareTo(other.Vitesse);
        }
        public override string ToString()
        {
            return "Caractéristiques de la voiture:\n"+"Marque:"+Marque+
                    "\nCouleur"+Couleur+"\nVitesse :  "+Vitesse;
        }
    }
}
