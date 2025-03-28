using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using hraTesty;

namespace TestyProOmagalulHru
{
    [TestClass]
    public class UnitTest1
    {
        HerniPostava hrac = new HerniPostava();
        
        [TestMethod]
        public void JmenoJeNastaveno()
        {
            Assert.IsNotNull(hrac.Jmeno);
        }

        [TestMethod]
        public void JmenoNeniNastaveno()
        {
            Assert.IsNull(hrac.Jmeno);
        }

        [TestMethod]
        public void JmenoDelsiNezTri()
        {
            int min = 3;
            Assert.IsTrue(hrac.Jmeno.Length >= min);
        }

        [TestMethod]
        public void JmenoDelsiNezDeset()
        {
            int max = 10;
            Assert.IsTrue(hrac.Jmeno.Length > max);
        }

        [TestMethod]
        public void LevelJeJedna()
        {
            Assert.IsTrue(hrac.Level == 1);
        }

        [TestMethod]
        public void LevelNeníJedna()
        {
            Assert.AreEqual(hrac.Level, 1);
        }

        [TestMethod]
        public void Xna0()
        {
            Assert.AreEqual(hrac.X, 0);
        }

        [TestMethod]
        public void XneNa0()
        {
            Assert.AreNotEqual(hrac.X, 0);
        }

        [TestMethod]
        public void Yna0()
        {
            Assert.AreEqual(hrac.Y, 0);
        }

        [TestMethod]
        public void YneNa0()
        {
            Assert.AreNotEqual(hrac.Y, 0);
        }

        // -------------------------------------------------------------

        [TestMethod]
        public void SpecializaceJeNastavena()
        {
            Assert.IsNotNull(hrac.Specializace);
        }

        [TestMethod]
        public void SpecializaceJeNastavenaNaKouzelnik()
        {
            Assert.AreEqual(hrac.Specializace, "Kouzelník");
        }

        [TestMethod]
        public void SpecializaceJeNastavenaNaBerserker()
        {
            Assert.AreEqual(hrac.Specializace, "Berserker");
        }

        [TestMethod]
        public void SpecializaceJeNastavenaNaInzenyr()
        {
            Assert.AreEqual(hrac.Specializace, "Inženýr");
        }

        [TestMethod]
        public void SpecializaceJeNastavenaNaCizak()
        {
            Assert.AreEqual(hrac.Specializace, "Cizák");
        }

        [TestMethod]
        public void XPna0()
        {
            Assert.AreEqual(hrac.XP, 0);
        }

        [TestMethod]
        public void XPvetsiNez0()
        { 
            Assert.IsTrue(hrac.XP > 0);
        }

        [TestMethod]
        public void LevelSeZvysiPoDostatecnemXP()
        {
            int puvodniLevel = hrac.Level;
            hrac.PridejXP(100);
            Assert.AreEqual(puvodniLevel + 1, hrac.Level);
        }

       
        [TestMethod]
        public void PridejXPNezvysiLevelPokudNeniDostatekXP()
        {
            int puvodniLevel = hrac.Level;
            hrac.PridejXP(50);
            Assert.AreEqual(puvodniLevel, hrac.Level);
        }

        [TestMethod]
        public void ToStringVraciNePrazdnyRetezec()
        {
            string vystup = hrac.ToString();
            Assert.IsFalse(string.IsNullOrEmpty(vystup));
        }
    }
}
