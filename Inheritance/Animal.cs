using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }

        public int Legs { get; set; }
        public bool HasFur { get; set; }	
        public string Color { get; set; }
        public bool HasTail { get; set; }

        public void PrintAnimal()
        {
            Console.WriteLine(Legs);
            Console.WriteLine(HasFur);
            Console.WriteLine(Color);
            Console.WriteLine(HasTail);
        } 






    }
}
