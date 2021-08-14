using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase db;

        [SetUp]
        public void Setup()
        {
            db = new ExtendedDatabase();
        }

        [Test]
        public void Ctor_AddInitialPeopleTtoDB()
        {
            var people = new Person[6];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Mr. {i}");
            }
            db = new ExtendedDatabase(people);
            Assert.That(db.Count, Is.EqualTo(people.Length));

            foreach (var person in people)
            {
                Person dbPerson = db.FindById(person.Id);
                Assert.That(person, Is.EqualTo(dbPerson));
            }
        }

        [Test]
        public void Ctor_ThrowsExceptionWhenCapacityExceeded()
        {
            var people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Name: {i}");
            }
            Assert.Throws<ArgumentException>(() => db = new ExtendedDatabase(people));
        } 
        
        [Test]
        public void Add_ThrowsExceptionWhenCapacityExceeded()
        {
            var n = 16;
            for (int i = 0; i < n; i++)
            {
                db.Add( new Person(i, $"Name: {i}"));
            }
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(16,"k,k")));
        }
        
        [Test]
        public void Add_ThrowsExceptionWhenNameAlreadyExists()
        {
            db.Add(new Person(0, "Misho"));
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(1, "Misho")));
        }
        
        [Test]
        public void Add_ThrowsExceptionWhenIdAlreadyExists()
        {
            db.Add(new Person(0, "Misho"));
            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(0, "Tisho")));
        }

        [Test]
        public void Add_IncrementsCountWhenAllIsValid()
        {
            var n = 6;
            for (int i = 0; i < n; i++)
            {
                db.Add(new Person(i, $"Misho{i}"));
            }
            Assert.That(db.Count, Is.EqualTo(n));
        }

        [Test]
        public void RemoveThrowsExceptionWhenDbEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }

        [Test]
        public void RemoveDecreasesCount()
        {
            db.Add(new Person(0, "k")); 
            db.Add(new Person(1, "koz"));
            int oldCount = db.Count;
            db.Remove();
            int newCount = db.Count;
            Assert.That(newCount, Is.EqualTo(oldCount - 1));
            Assert.Throws<InvalidOperationException>(() => db.FindById(1));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ThrowsExWhenArgumentNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(name));
        }

        [Test]
        public void FindByUsername_ReturnsCorrectResult()
        {
            var person = new Person(0, "Misho");
            db.Add(person);
            var dbPerson = db.FindByUsername(person.UserName);
            Assert.That(person, Is.EqualTo(dbPerson));
        }

        [Test]
        public void FindById_ThrowsExWhenIdBelow0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));
        }

        [Test]
        public void FindById_ThrowsExWhenIdDoesNotExist()
        {
            var person = new Person(0, "Misho");
            db.Add(person);
            Assert.Throws<InvalidOperationException>(() => db.FindById(1));
        }

        [Test]
        public void FindById_ReturnsCorrectResult()
        {
            var person = new Person(0, "Misho");
            db.Add(person);
            var dbPerson = db.FindById(person.Id);
            Assert.That(person, Is.EqualTo(dbPerson));
        }
    }
}