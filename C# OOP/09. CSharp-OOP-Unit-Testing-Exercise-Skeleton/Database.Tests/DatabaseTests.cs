using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database(); 
        }

        [Test]
        public void Ctor_ThrowsExceptionWhenAmmountExceeded()
        {
            Assert.Throws<InvalidOperationException>(() => database = new Database(0, 1, 0, 1, 0, 1, 0, 7, 0, 1, 0, 1, 0, 1, 0, 15, 16));
        }
        
        [Test]
        public void Ctor_AddsValidElementsToDB()
        {
            int[] items = new int[] { 1, 2, 3 };
            database = new Database(items);
            Assert.That(database.Count, Is.EqualTo(items.Length));
        }
        
        [Test]
        public void Add_IncrementsCountWhenAdddingValidElements()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                database.Add(n);
            }
            Assert.That(database.Count, Is.EqualTo(n));
        }

        [Test]
        public void Add_ThrowsExceptionWhenAmountExceeded()
        {
            var n = 16;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);

            }
            Assert.Throws<InvalidOperationException>(() => database.Add(n));
        }

        [Test]
        public void Remove_ThrowsExceptionWhenDBEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        
        [Test]
        public void Remove_DecreasesDBCount()
        {
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }
            database.Remove();
            Assert.That(database.Count,Is.EqualTo(n-1));
        }
        
        [Test]
        public void Remove_RemovesFromDB()
        {
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }
            database.Remove();
            var newDB = database.Fetch();
            Assert.IsFalse(newDB.Contains(3));
        }

        [Test]
        public void Fetch_ReturnsCopyNotReference()
        {
            database.Add(1);
            database.Add(2);
            var copyOne = database.Fetch();
            database.Add(3);
            var copyTwo = database.Fetch();
            Assert.That(copyOne, Is.Not.EqualTo(copyTwo));
        }
    }
}