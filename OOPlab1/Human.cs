using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private decimal _salary;
        public decimal Salary
        {
            get => _salary;
            set
            {
                if ((value > 0))
                {
                    _salary = value;
                }
            }
        }
    }
}
