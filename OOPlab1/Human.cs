using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        public DateTime ModefyDate = DateTime.Now;
        
        

        public int Salary
        {
            get
            {
                Console.WriteLine("the date of modefication is " + ModefyDate);
                return Salary;
               

            }
            set
            {
                if (value > 0) 
                {
                    Salary = value;
                    Console.WriteLine(ModefyDate);
                    ModefyDate = DateTime.Now;
                }
            }

        }

        private Car car;
        public Car Car
        {
            get
            {

                return car;


            }
            set
            {
                if (value.value > Salary)
                {
                    
                    Console.WriteLine("Yuor salary is enaugh to buy a car");

                }
                else
                {
                    Console.WriteLine("Sorry you are too Poor");
                }
            }

        }
    }

    
}
