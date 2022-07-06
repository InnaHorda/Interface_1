using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_1
{
    class light:ISwitchable
    {
        public void Swich_on()
        {
            Console.WriteLine("Light  is swiching on");
        }
        public void Swich_of()
        {
            Console.WriteLine("Light is swiching of");
        }
    }
}
