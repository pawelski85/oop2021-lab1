using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Phone {
        public readonly string Producer;
        public readonly string Model;
        public readonly double ScreenSize;
        public string OS;

        public Phone(string producer, string model, double screenSize, string os) {
            Producer = producer;
            Model = model;
            ScreenSize = screenSize;
            OS = os;
        }
    }
}
