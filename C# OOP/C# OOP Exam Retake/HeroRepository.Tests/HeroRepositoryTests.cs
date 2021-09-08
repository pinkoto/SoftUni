using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    public HeroRepository heroRepository;

    [SetUp]
    public void Initialize()
    {
        heroRepository = new HeroRepository();
    }

    [Test]
    public void CreateTEWHeroIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(null));
    }

    [Test]
    public void CreateTEWHeroNameInUse()
    {
        Hero hero = new Hero("gogo", 1);
        heroRepository.Create(hero);
        Hero hero2 = new Hero("gogo", 1);

        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero2));
    }

    [Test]
    public void CreateIncrementsCount()
    {
        heroRepository.Create(new Hero("aaa", 1));
        Assert.That(heroRepository.Heroes.Count, Is.EqualTo(1));
    }

    [Test]
    public void RemoveTEWHeroIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(null));
    }

    [Test]
    public void RemoveDecreasesCount()
    {
        heroRepository.Create(new Hero("pesho", 5));
        heroRepository.Create(new Hero("gosho", 5));
        int first = heroRepository.Heroes.Count;
        bool success = heroRepository.Remove("pesho");
        Assert.IsTrue(success);
        Assert.That(heroRepository.Heroes.Count, Is.EqualTo(first - 1));

    }

    [Test]
    public void GetHeroWithHighestLevelWorksOk()
    {
        Hero gogo = new Hero("gogo", 16);
        heroRepository.Create(gogo);
        heroRepository.Create(new Hero("pepi", 12));
        Hero hero = heroRepository.GetHeroWithHighestLevel();
        Assert.That(gogo, Is.EqualTo(hero));
    }

    [Test]
    public void GetHeroWorksOk()
    {
        Hero gogo = new Hero("gogo", 16);
        heroRepository.Create(gogo);
        heroRepository.Create(new Hero("pepi", 12));
        Assert.That(gogo, Is.EqualTo(heroRepository.GetHero("gogo")));
    }
}