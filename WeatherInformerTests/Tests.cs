using System;
using System.Data;
using NUnit.Framework;
using WeatherInformer;

namespace WeatherInformetTests
{
    [TestFixture]
    public class Tests
    {
        DB db = DB.getDB();
        [Test]
        public void GetAllClothes()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetAllUsers()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetAllWeather()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetAllSites()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetStandartClothes()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLastLoggedUser()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddUser()
        {
            int expected = 15;
            DataTable table;

            table = db.GetAllClothes();

            int actual = table.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}