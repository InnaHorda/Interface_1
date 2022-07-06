using System;
using System.Collections.Generic;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> Equipments = new List<ISwitchable>();
            Equipments.Add(new TV());
            Equipments.Add(new light());
           foreach(ISwitchable equipment in Equipments)
            {
                equipment.Swich_on();
                equipment.Swich_of();
                Console.WriteLine();
            }
        }
    }
}
