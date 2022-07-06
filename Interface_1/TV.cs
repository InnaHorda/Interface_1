using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_1
{
    class TV:ISwitchable
    {
        public void Swich_on()
        {
            Console.WriteLine("Tv is swiching on");
        }
        public void Swich_of()
        {
            Console.WriteLine("Tv is swiching of");
        }
    }
}
