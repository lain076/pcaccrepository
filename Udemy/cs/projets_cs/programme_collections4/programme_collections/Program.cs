using System;
using System.Collections.Generic;

namespace programme_collections
{
    class Program
    {
        // Somme (int a, int b, int c)
        static int SommeTableau(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }

            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            // La valeur maximale est : xx
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximale est : " + max);
        }

        static void AfficherValeurMinimale(int[] t)
        {
            // La valeur maximale est : xx
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur minimale est : " + min);
        }

        static void Tableaux()
        {
            //int[] t = { 200, 40, 15, 8, 12 };
            const int TAILLE_TABLEAU = 20;

            // int[] t
            // Initialiser chaque element valeur aléatoire entre 0 et 100

            int[] t = new int[TAILLE_TABLEAU];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(101);
            }

            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimale(t);


        }

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if (!ordreDescendant)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                // 3 
                // 2 1 0
                for (int i = liste.Count-1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            // "le nom le plus grand est : "
            string nomLePlusLong = "";
            int longueurMax = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                string nom = liste[i];
                if (nom.Length > longueurMax)
                {
                    longueurMax = nom.Length;
                    nomLePlusLong = nom;
                }
            }

            Console.WriteLine("Le nom le plus long est : " + nomLePlusLong);

            
        }

        static void AfficherElementsCommuns(List<string> liste1, List<string> liste2)
        {
            for (int i = 0; i < liste1.Count; i++)
            {
                string nom1 = liste1[i];
                /*if (liste2.Contains(nom1))
                {
                    Console.WriteLine(nom1);
                }*/
                for (int j = 0; j < liste2.Count; j++)
                {
                    string nom2 = liste2[j];
                    if (nom1 == nom2)
                    {
                        Console.WriteLine(nom1);
                    }
                }
            }
        }

        static void Listes()
        {
            /*List<int> liste = new List<int>();

            liste.Add(5);
            liste.Add(8);
            liste.Add(2);
            liste.Add(2);
            liste.Add(2);

            liste[2]++;
            //liste.Remove(8);
            liste.RemoveAt(1);

            AfficherListe(liste);*/

            /*var noms = new List<string>() { "Jean", "Paul"};
            while(true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir) : ");
                string nom = Console.ReadLine();

                if (nom == "")
                {
                    break;
                }

                if (noms.Contains(nom))
                {
                    Console.WriteLine("Erreur, ce nom est déjà dans la liste");
                    Console.WriteLine();
                }
                else
                {
                    noms.Add(nom);
                }
            }

            //List<string> lesPremiersNoms = noms.GetRange(0, 3);

            // Filtrer : Supprimer tous les noms qui terminent par "e".
            // RemoveAt / longueur de la liste est altérée
            // Bouclez en partant de la fin

            for (int i = noms.Count - 1; i >= 0; i--)
            {
                string nom = noms[i];
                if (nom[nom.Length-1] == 'e')
                {
                    noms.RemoveAt(i);
                }
            }

            AfficherListe(noms, true);*/

            var liste1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin" };
            var liste2 = new List<string>() { "sophie", "jean", "martin", "toto" };
            // jean, martin

            AfficherElementsCommuns(liste1, liste2);
            // contains

        }

        static void Main(string[] args)
        {
            //Tableaux();
            Listes();
        }
    }
}
