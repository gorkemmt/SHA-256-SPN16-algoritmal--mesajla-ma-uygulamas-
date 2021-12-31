using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProje
{
    [TestClass]
    public class UnitTest1
    {
        yazilim_sinama_v1._1.Anasayfa test = new yazilim_sinama_v1._1.Anasayfa();

        [TestMethod]
        public void TestENGcevir()
        {
            string testsonuc = test.ENGCevir("ÇĞÜŞÖ");
            Assert.AreEqual(testsonuc,"CGUSO");
        }

        [TestMethod]
        public void TestBinaryCevir()
        {
            string testsonuc = test.BinaryCevir("as");
            Assert.AreEqual(testsonuc, "0110000101110011");
        }

        [TestMethod]
        public void TestStringeCevir()
        {
            string testsonuc = test.StringeCevir("0110000101110011");
            Assert.AreEqual(testsonuc,"as");
        }

        [TestMethod]
        public void TestKaristirSifrele()
        {
            string testsonuc = test.KaristirSifrele("1234567890123456");
            Assert.AreEqual(testsonuc,"3936015522674184");
        }

        [TestMethod]
        public void TestDegerParcala()
        {
            string testsonuc = test.DegerParcala("sifre",0);
            Assert.AreEqual(testsonuc, "0111001101101001");
        }

    }
}
