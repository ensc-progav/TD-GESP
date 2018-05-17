using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    // Représente un lien web
    public class Lien
    {
        public string titre { get; private set; }
        public string Url { get; private set; }

        public Lien(string un_titre, string un_url)
        {
            titre = un_url;
            Url = un_url;
        }

        public override string ToString()
        {
            return titre + " " + Url;
        }
    }
}
