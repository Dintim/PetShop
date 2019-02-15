using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public abstract class Animal
    {
        public string Name { get; set; } = "";
        public string Sex { get; set; } = "";
        public DateTime BirthDayDate { get; set; } = DateTime.Now;
        public int Price { get; set; } = 0;

        public Animal() { }
        public Animal(string name, string sex, DateTime bdDate, int price)
        {
            Name = name;
            Sex = sex;
            BirthDayDate = bdDate;
            Price = price;
        }
        public abstract string getType();
        
        public abstract void getInfo();
    }

    public class Elephant:Animal
    {
        public static int Id = 0;

        public string Articul { get; set; }
        public string Color { get; set; } = "";
        public bool HasTusks { get; set; } = false;

        public Elephant()
        {
            ++Id;
            this.Articul = "E" + Id;
        }        
        public Elephant(string name, string sex, DateTime bdDate, int price, string color, bool hasTasks) :base(name, sex, bdDate, price)
        {
            ++Id;
            this.Articul = "E" + Id;
            this.Color = color;
            this.HasTusks = hasTasks;
        }

        public override string getType()
        {
            return typeof(Elephant).ToString().Substring(8);
        }
        public override void getInfo()
        {
            Console.WriteLine("articul: {0}\n" +
                "animal: {1}\n" +
                "name: {2}\n" +
                "sex: {3}\n" +
                "birth day: {4}\n" +
                "color: {5}\n" +
                "has tasks: {6}\n" +
                "price: {7}\n", Articul,typeof(Elephant).ToString().Substring(8), Name, Sex, BirthDayDate, Color, HasTusks, Price);
        }
    }

    public class Giraffe:Animal
    {
        public static int Id = 0;

        public string Articul { get; set; }
        public int NeckLength { get; set; } = 0;

        public Giraffe()
        {
            ++Id;
            this.Articul = "G" + Id;
        }
        public Giraffe(string name, string sex, DateTime bdDate, int price, int neckLength):base(name, sex, bdDate, price)
        {
            ++Id;
            this.Articul = "G" + Id;
            this.NeckLength = neckLength;
        }
        public override string getType()
        {
            return typeof(Giraffe).ToString().Substring(8);
        }
        public override void getInfo()
        {
            Console.WriteLine("articul: {0}\n"+
               "animal: {1}\n" +
               "name: {2}\n" +
               "sex: {3}\n" +
               "birth day: {4}\n" +
               "neck length: {5}\n"+
               "price: {6}\n", Articul,typeof(Giraffe).ToString().Substring(8), Name, Sex, BirthDayDate, NeckLength, Price);
        }
    }

    public class Cat:Animal
    {
        public static int Id = 0;

        public string Articul { get; set; }
        public string Color { get; set; } = "";
        public string Breed { get; set; } = "";

        public Cat()
        {
            ++Id;
            this.Articul = "C" + Id;
        }
        public Cat(string name, string sex, DateTime bdDate, int price, string color, string breed):base(name, sex, bdDate, price)
        {
            ++Id;
            this.Articul = "C" + Id;
            this.Color = color;
            this.Breed = breed;
        }
        public override string getType()
        {
            return typeof(Cat).ToString().Substring(8);
        }
        public override void getInfo()
        {
            Console.WriteLine("articul: {0}\n"+
               "animal: {1}\n" +
               "name: {2}\n" +
               "sex: {3}\n" +
               "birth day: {4}\n" +
               "color: {5}\n" +
               "breed: {6}\n" +
               "price: {7}\n", Articul,typeof(Cat).ToString().Substring(8), Name, Sex, BirthDayDate, Color, Breed, Price);
        }
    }

    public class Dog : Animal
    {
        public static int Id = 0;

        public string Articul { get; set; }
        public string Color { get; set; } = "";
        public string Breed { get; set; } = "";
        public bool IsGuide { get; set; } = false;

        public Dog()
        {
            ++Id;
            this.Articul = "D" + Id;
        }
        public Dog(string name, string sex, DateTime bdDate, int price, string color, string breed, bool isGuide):base(name, sex, bdDate, price)
        {
            ++Id;
            this.Articul = "D" + Id;
            this.Color = color;
            this.Breed = breed;
            this.IsGuide = isGuide;
        }
        public override string getType()
        {
            return typeof(Dog).ToString().Substring(8);
        }
        public override void getInfo()
        {
            Console.WriteLine("articul: {0}\n" +
               "animal: {1}\n" +
               "name: {2}\n" +
               "sex: {3}\n" +
               "birth day: {4}\n" +
               "color: {5}\n" +
               "breed: {6}\n" +
               "is guide dog: {7}\n" +
               "price: {8}\n", Articul, typeof(Dog).ToString().Substring(8), Name, Sex, BirthDayDate, Color, Breed, IsGuide,Price);
        }

    }



}
