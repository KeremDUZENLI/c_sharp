﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class GruplayiciTests
    {
        private List<Olcum>OlcumListesiOlustur(int adet)
        {
            var olcumler = new List<Olcum>();

            for (int i = 0; i < adet; i++)
            {
                olcumler.Add(new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                });
            }

            return olcumler;
        }

        [TestMethod]
        public void bir_elemanli_liste_birerli_gruplanmak_istendiğinde_grup_sayisi_bir_olmalidir()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                }
            };

            var gruplayici = new Gruplayici(1);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(1, gruplar.Count);
        }

        [TestMethod]
        public void alti_elemanli_liste_ikiserli_gruplanmak_istendiğinde_grup_sayisi_uc_olmalidir()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                },
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                },
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                },
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                },
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                },
                new Olcum
                {
                    EnYüksek = 10,
                    EnDüsük = 1
                }
            };

            var gruplayici = new Gruplayici(2);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(3, gruplar.Count);
        }

        [TestMethod]
        public void elli_elemanli_liste_onarli_gruplanmak_istendiğinde_grup_sayisi_bes_olmalidir()
        {
            var olcumler = OlcumListesiOlustur(50);

            var gruplayici = new Gruplayici(10);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(5, gruplar.Count);
        }
    }
}
