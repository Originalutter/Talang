using System;
using NUnit.Framework;

namespace MyApplication
{
    [TestFixture]
    public class TestClasses
    {
        [Test]
        public void should_be_able_to_create_an_instance_of_dog()
        {
            var lassie = new Dog();
            Assert.That(lassie, Is.InstanceOf<Dog>());
        }

        [Test]
        public void lassie_is_yellow()
        {
            var lassie = new Dog { Color = "yellow" };
            Assert.That(lassie.Color, Is.EqualTo("yellow"));
        }

        [Test]
        public void lassie_talks()
        {
            var lassie = new Dog();
            var hello = lassie.Says("hello");
            var feedMe = lassie.Says("feed me");

            Assert.That(hello, Is.EqualTo("BARF!"));
            Assert.That(feedMe, Is.EqualTo("WOOF!"));
        }

        [Test]
        public void dog_is_an_animal()
        {
            var lassie = new Dog();

            Assert.That(lassie, Is.InstanceOf<Animal>());
        }

        [Test]
        public void dog_and_cat_has_different_IQ()
        {
            var cheeta = new Cat();
            var lassie = new Dog();

            Assert.That(cheeta.IQ, Is.GreaterThan(lassie.IQ));
        }

        [Test]
        public void kennel_has_1_dog_and_2_cats()
        {
            var donna = new Cat();
            var cheeta = new Cat();
            var lassie = new Dog();

            Kennel.HousesPet(donna);
            Kennel.HousesPet(cheeta);
            Kennel.HousesPet(lassie);

            Assert.That(Kennel.NoOfDogs, Is.EqualTo(1));
            Assert.That(Kennel.NoOfCats, Is.EqualTo(2));
        }

        [Test]
        public void cheeta_is_female()
        {
            var cheeta = new Cat(Gender.Female);
            Assert.That(cheeta.Gender, Is.EqualTo(Gender.Female));
        }

        [Test]
        public void lassie_is_male()
        {
            var lassie = new Dog(Gender.Male);
            Assert.That(lassie.Gender, Is.EqualTo(Gender.Male));
        }

        [Test]
        public void lassie_is_fetching_shoes()
        {
            var lassie = new Dog();
            Assert.That(lassie.GetLoafers(), Is.EqualTo("Happy to oblige master!"));
        }

        [Test]
        public void cheeta_is_not_fetching_shoes()
        {
            var cheeta = new Cat();
            var exception = Assert.Throws<CatException>(() => cheeta.GetLoafers());
            Assert.That(exception.Message, Is.EqualTo("not gonna happen"));
        }
    }

    public enum Gender
    {
        Female,
        Male
    }

    public abstract class Animal
    {
        public int IQ;
        public Gender Gender;
        public abstract string GetLoafers();
    }

    public class Dog : Animal
    {
        public Dog()
        {
            IQ = 40;
        }

        public Dog(Gender gender)
        {
            IQ = 40;
            Gender = gender;
        }

        public string Color;

        public string Says(string word)
        {
            switch (word)
            {
                case "hello":
                    return "BARF!";
                case "feed me":
                    return "WOOF!";
                default:
                    return "";
            }
        }

        public override string GetLoafers()
        {
            return "Happy to oblige master!";
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            IQ = 45;
        }

        public Cat(Gender gender)
        {
            IQ = 45;
            Gender = gender;
        }

        public override string GetLoafers()
        {
            throw new CatException("not gonna happen");
        }
    }

    public class CatException : Exception
    {
        public CatException(string msg)
            : base(msg)
        {
        }
    }

    public class Kennel
    {
        public static int NoOfDogs;
        public static int NoOfCats;

        public static void HousesPet(Animal animal)
        {
            switch (animal.GetType().Name)
            {
                case "Cat":
                    NoOfCats++;
                    break;
                case "Dog":
                    NoOfDogs++;
                    break;
            }
        }
    }
}