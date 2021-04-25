using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        public readonly string Species = "canis";
        public string Name;
        private double weight;

        public Animal(double weight)
        {
            this.weight=weight;
        }

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight) {
            weight += foodWeight;
            Console.WriteLine("thx for food, bro");
            Console.WriteLine("my weight is now " + weight);
        }

        public String returnSpeciesAndName() {
            return Species + " " + Name;
        }

        public String returnNameAndOwner(string owner) {
            return Name + " " + owner;
        }

        public void TakeForAWalk()
        {
            this.weight -= 1;
    
            Console.WriteLine("thx for loosing weight, bro");
            Console.WriteLine("my weight is now " + weight);
        }

    }
}
