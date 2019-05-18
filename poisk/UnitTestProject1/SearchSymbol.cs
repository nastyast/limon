using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2
{
    [TestClass]
    public class SearchSymboltest
    {
        [TestMethod]
        public void TestMethod1()
        {
        
            string a = "Петя Иванов съел лимон";
            char c = 'н';
            int expected = 2;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Poisksimvole2()
        {

            string a = "Мир, труд, май!";
            char c = 'м';
            int expected = 2;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Poisksimvole3()
        {

            string a = "Сижу за решеткой в темнице сырой";
            char c = 'ь';
            int expected = 0;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Poisksimvolefunctiontest()
        {

            string a = "Мы вольные птицы; пора, брат, пора!";
            char c = 'ф';
            int expected = 0;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Poisksimvolefunctiontest1()
        {

            string a = "Давай улетим!";
            char c = 'а';
            int expected = 2;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Poisksimvolefunctiontest2()
        {

            string a = "Давай улетим!";
            char c = ' ';
            int expected = 0;

            int actual = SearchSymbol.poisk(a, c);

            Assert.AreEqual(expected, actual);

        }
    }
}
