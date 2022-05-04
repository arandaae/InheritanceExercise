using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            HasFur = false;
            Color = "black and white, some yellow";
            HasTail = true; 
        }

        public bool CanFly { get; set; }
        public string BeakSize { get; set; }
        public bool HasWebbedFeet { get; set; }
        public string WingSpanSize { get; set; }

        public void PrintBird()
        {
           
        }


    }
}
