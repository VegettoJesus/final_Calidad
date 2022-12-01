using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;

namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]
        public void GetJugadaTest()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 8,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest2()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 5,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest3()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("FULL", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest4()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12,
                       Palo = "CORAZON"
                    },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("DOBLE PAREJA", cartaList);
        }
    }
}