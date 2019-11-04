using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_gardiens
{
    class Program
    {

        
        static Random generateur = new Random();
        public struct Vaisseaux
        {
            public Vaisseaux[] tabVaisseaux;
            public string nom;
            private int vitesse;
            private int vie;
            private int prix;
            public Vaisseaux(string _nom) : this()
            {
                tabVaisseaux = new Vaisseaux[10];
                nom = _nom;
                for (int i = 0; i < tabVaisseaux.Length; i++)
                {
                    tabVaisseaux[i] = new Vaisseaux(generateur.Next(11, 71), generateur.Next(101, 2001),generateur.Next(2001,20001));
                }
            }
            
            public Vaisseaux(int _vit, int _vie, int _prix) : this()
            {
                vitesse = _vit;
                vie = _vie;
                prix = _prix;

            }

            static void Main(string[] args)
             {
            double moyennePrix = 0;
            int nombreVie = 0;
            int vitesse = 0;
            int choix = 0;
            Console.WriteLine("Bonjour aventuriers de l'espace j'ai pour vous quelques vaisseaux qui pourrait vous interesser!:)");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Votre menu!");
            Console.WriteLine("-----------");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1-Afficher les vaisseaux avec toutes les caracéristiques.");
            Console.WriteLine("2-Vérifier si un vaisseau légendaire existe.");
            Console.WriteLine("3-Trouver le vaisseau avec la vie la plus haute.");
            Console.WriteLine("4-Afficher la moyennne des prix des vaisseaux.");
            Console.WriteLine("5-Quitter le programme.");
            choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    Console.WriteLine("Voici les differentes caractéristiques des vaisseaux.");
                    System.Threading.Thread.Sleep(1500);
                }
                else if (choix == 2)
                {

                }
                else if (choix == 3)
                {
                    AfficherVaisseauxPlusVie(ref ();
                }
                else if (choix == 4)
                {
                    AfficherMoyennePrix();

                }
                else if (choix == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Au revoir, à la prochaine !!!");
                }
                else
                    Console.WriteLine("Entrez un nombre valide!");


            }

            

            static void AfficherMoyennePrix(ref Vaisseaux[] tabVaisseaux)
            {
                int moyenne = 0, tot = 0;
                for (int i = 0; i < tabVaisseaux.Length; i++)
                {
                    tot += tabVaisseaux[i].prix;
                }

                moyenne = tot / tabVaisseaux.Length;
                Console.WriteLine("La moyenne de prix des vaisseaux est de: " + moyenne);
            }
            static void AfficherVaisseauxPlusVie(ref Vaisseaux[] tabVaisseaux)
            {
                int plusVie = 0;
                int pos = 0;
                for (int i = 0; i < tabVaisseaux.Length; i++)
                {
                    if (tabVaisseaux[i].vie > plusVie)
                    {
                        plusVie = tabVaisseaux[i].vie;
                        pos = i;
                    }
                }
                Console.WriteLine("Le vaisseau ayant le plus de vie est le vaisseau no "
                    + (pos + 1) + " ayant " + plusVie + " de vie");
            }
        }
    }
}
