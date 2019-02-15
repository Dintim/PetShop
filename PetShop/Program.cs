using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant("Dumbo", "male", new DateTime(1983, 5, 22), 500000, "grey", true);
            Cat c = new Cat("Murka", "female", new DateTime(2017, 6, 7), 5000, "white", "persian");            
            Elephant e2 = new Elephant();
            

            PetShop p = new PetShop();            
            p.addAnimal(e);
            p.addAnimal(c);
            p.addAnimal(e2);
            p.printAllAnimals();
        }
    }
}
