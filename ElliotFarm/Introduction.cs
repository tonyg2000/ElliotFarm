using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Introduction
    {
        public void FarmHeader()
        {
            Console.WriteLine("===============================================================================");

            Console.WriteLine("Welcome to Elliot's Farm. \nProud to be family owned and operated for over 70 years.\n" +
                "Enjoy our animals and have a wonderful day");
            Console.ResetColor();

            Console.WriteLine("===============================================================================");
            Console.ReadKey();
            
        }

        public void FarmMenu()
        {
            Console.WriteLine("Animals");
            Console.WriteLine("1: Cow");
            Console.WriteLine("2: Sheep");
            Console.WriteLine("3: Pig");
            Console.WriteLine("4: Horse");
            Console.WriteLine("q. Exit");

        }



    }
}
