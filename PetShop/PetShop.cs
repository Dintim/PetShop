using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    public class PetShop
    {
        public string Name { get; set; }        
        private List<Animal> animals = new List<Animal>();        

        public PetShop() { }
        public PetShop(string name)
        {
            this.Name = name;
        }
        public void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void delAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
        public void delAnimal(string name)
        {
            animals.Remove(animals.Find(x => x.Name == name));
        }
        public Animal getAnimalByIndex(int index)
        {
            return animals[index];
        }        
        public Animal getAnimalByName(string name)
        {
            return animals.Find(x => x.Name == name);
        }

        public List<Elephant> getElephantsList()
        {
            List<Elephant> elephants = new List<Elephant>();
            for (int i = 0; i < animals.Count; i++)
            {
                Elephant e = new Elephant();
                if (animals[i].getType() == "Elephant")
                {
                    e = (Elephant)animals[i];
                    elephants.Add(e);
                }
            }
            return elephants;
        }

        public List<Giraffe> getGiraffesList()
        {
            List<Giraffe> giraffes = new List<Giraffe>();
            for (int i = 0; i < animals.Count; i++)
            {
                Giraffe e = new Giraffe();
                if (animals[i].getType() == "Giraffe")
                {
                    e = (Giraffe)animals[i];
                    giraffes.Add(e);
                }
            }
            return giraffes;
        }

        public List<Cat> getCatsList()
        {
            List<Cat> cats = new List<Cat>();
            for (int i = 0; i < animals.Count; i++)
            {
                Cat e = new Cat();
                if (animals[i].getType() == "Cat")
                {
                    e = (Cat)animals[i];
                    cats.Add(e);
                }
            }
            return cats;
        }
        public List<Dog> getDogsList()
        {
            List<Dog> dogs = new List<Dog>();
            for (int i = 0; i < animals.Count; i++)
            {
                Dog e = new Dog();
                if (animals[i].getType() == "Dog")
                {
                    e = (Dog)animals[i];
                    dogs.Add(e);
                }
            }
            return dogs;
        }

        public void printAllAnimals()
        {
            for (int i = 0; i < animals.Count; i++)
                animals[i].getInfo();
        }



    }
}
