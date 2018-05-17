using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PubLinkLib.Collection listeLien = new PubLinkLib.Collection(); ;
            listeLien.Ajouter(new PubLinkLib.Lien("Hacker News", "https://news.ycombinator.com"));
            listeLien.Ajouter(new PubLinkLib.Lien("Reddit", "https://reddit.com"));
            listeLien.Ajouter(new PubLinkLib.Lien("Boing Boing", "boingboing.net"));

            string choix = "";
            while (choix != "0")
            {
                string choix_possibles = "\n1 : Lister les liens";
                choix_possibles += "\n0 : Quitter";
                Console.WriteLine("Choisissez une action : " + choix_possibles);
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        if (listeLien.Compte > 0)
                        {
                            for (int i = 0; i < listeLien.Compte; i++)
                            {
                                Console.WriteLine((i+1) + " : " + listeLien.Get(i));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Aucun lien à afficher !");
                        }
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Au revoir !");

            Console.ReadKey();
        }
    }
}
