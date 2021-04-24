using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        public readonly string Species = "canis";
        public string Name;
        private double weight = 3.0;

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void Feed(Double foodWeight) {
            weight += foodWeight;
            Console.WriteLine("thx for food, bro");
            Console.WriteLine("my weight is now " + weight);
        }


    }
}
