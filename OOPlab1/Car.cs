using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    public class Car
    {
        public string Make;
        public string Modle;
        public decimal value;
        public DateTime Modelyear = DateTime.Now;

        public Car(string make, string modle, decimal value, DateTime modelyear)
        {
            Make = make;
            Modle = modle;
            this.value = value;
            Modelyear = modelyear;
        }



       

        public override bool Equals(object obj)
        {
            if (Make == Modle) { 

            return base.Equals(obj);

            }
            else
            {
                Console.WriteLine("the make and the model are not equal");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }




    }


}
