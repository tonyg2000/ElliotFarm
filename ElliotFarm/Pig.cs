using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Pig : Horse
    {
        public virtual void MakePig()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t=====================================================");
            Console.WriteLine("\t\t\t\t \t\t\tPORKY   ");
            Console.Write("\t\t\t\t====================================================== ");
            Console.WriteLine(" ");

            string pig = @"
                                                           --.__.--
                                                        ___\(0_0)/
                                                     ~~/     (OO)
                                                         \  __  /
                                                         `='`='=|";

            Console.WriteLine(pig);
           
            Console.WriteLine(" ");
        }


        public override void Speak()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(" ");
            Console.WriteLine("============= ");
            Console.WriteLine(" PORKY ");
            Console.WriteLine("============= ");
            Console.WriteLine(" ");


            Console.WriteLine("1. I'm Porky and tha, that, that's ok " +
                "weissd-d-d-dorn" +
                " 'he left out a buh-buh buh-buh bunch of stuff' ");
            
            Console.WriteLine(" ");
        }

        public override void Eat()
        {

            Console.WriteLine("2. I turn vegetables into bacon, what's your super power?'");
           
            Console.WriteLine(" ");
        }

        public override void Move()
        {
            Console.WriteLine("3. Sweat like me and run like a champ.");
            
            Console.WriteLine(" ");

        }

        public override void Sleep()
        {
            Console.WriteLine("4. I made no effort to start my diet and I ignored all of my friend's text reminding me to meet them a the gym.");
         
            Console.WriteLine(" ");
            Console.ResetColor();


        }
    }
}
