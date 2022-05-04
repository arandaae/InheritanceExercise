using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 0;
            HasFur = false;
            Color = "";
            HasTail = true;

        }

        public string ColdBlooded { get; set; }

        public string Scales { get; set; }
        public bool LaysEggs { get; set; }
        public bool ShedsSkin { get; set; }
        

        

        public void PrintReptile()
        {
            Console.WriteLine(ColdBlooded);
            Console.WriteLine(Scales);
            Console.WriteLine(LaysEggs);
            Console.WriteLine(ShedsSkin);
        }






    }
}
