using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Horse
    {
        public virtual void MakeHorse()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t=====================================================");
            Console.WriteLine("\t\t\t\t \t\t\tMr. Ze Brah  ");
            Console.Write("\t\t\t\t====================================================== ");
            //Console.WriteLine(" ");

            string horse = @"
                                                        ,--,
                                                 _ ___ / /\|
                                              ,;'( )__, )  ~       
                                             //  //'  --; 
                                             '   \    | ^
                                                  ^    ^";

            Console.WriteLine(horse);
       
        }

        public virtual void Speak()
        {
            Console.WriteLine(" ");
            Console.WriteLine("============= ");
            Console.WriteLine(" Mr. Ze Brah ");
            Console.WriteLine("============= ");
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("`1. Hello, my name is Mr. Ze Brah, and I am a striped horse. I say neiiiiiiigh!");
           
            Console.WriteLine(" ");
        }

        public virtual void Eat()
        {

            Console.WriteLine("2. my favorite food is hay, grass, and carrotsssssssssss, yes 'carrotssssssssss'");
          
            Console.WriteLine(" ");
        }

        public virtual void Move()
        {
            Console.WriteLine("3. I am a very fast stallion I can run up to 55 mph.");
          
            Console.WriteLine(" ");

        }

        public virtual void Sleep()
        {
            Console.WriteLine("4. To avoid being a easy prey, I fall asleep standing up.");
           
            Console.WriteLine(" ");
          
        }
    }
}
