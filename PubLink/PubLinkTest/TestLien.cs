using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestLien
    {
        [TestMethod]
        public void TestCreerLien()
        {
            string Titre = "Wikipedia";
            string URL = "http://wikipedia.org";

            Lien lien = new Lien(Titre, URL);

            Assert.AreEqual(Titre, lien.titre);
            Assert.AreEqual(URL, lien.Url);
            Assert.AreEqual(Titre + " " + URL, lien.ToString());
        }
    }
}
