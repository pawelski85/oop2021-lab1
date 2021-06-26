using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Animal
    {
        public readonly string Species = "canis";
        public string Name;
        private double weight = 3.0;
        public int walk;

        public Animal(string species, string name, double weight, int walk)
        {
            Species = species;
            Name = name;
            this.weight = weight;
            this.walk = walk;
        }

        public void PrintWeight()
        {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight)
        {
            weight += foodWeight;
            Console.WriteLine("thx for food, bro");
            Console.WriteLine("my weight is now " + weight);
        }

        public String returnSpeciesAndName()
        {
            return Species + " " + Name;
        }

        public String returnNameAndOwner(string owner)
        {
            return Name + " " + owner;
        }

        public Animal(double weight)
        {
            this.weight = weight;
            if (weight == 0)
            {
                Feed(2.5);
            }
            else
            {
                Console.WriteLine("your Dog is is too skinny");
                Console.WriteLine("Yuo shouf feel your dog by " + weight);
            }
        }

       
    }

}
