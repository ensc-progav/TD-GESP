using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    // Représente une collection de liens web
    public class Collection
    {
        private List<Lien> listeliens;

        public Collection()
        {
        }

        public int Compte
        {
            get { return listeliens.Count; }
        }

        public Lien Get(int indice)
        {
            return listeliens.ElementAt(indice);
        }

        public void Ajouter(Lien un_lien)
        {
            listeliens.Add(un_lien);
        }
    }
}
