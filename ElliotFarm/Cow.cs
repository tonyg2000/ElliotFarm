using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Cow: Horse
    {
        public virtual void MakeCow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t=====================================================");
            Console.WriteLine("\t\t\t\t \t\t\tAnnabelle  ");
            Console.Write("\t\t\t\t====================================================== ");
            Console.WriteLine(" ");

            string cow = @"
                                                              __n__n__
                                                       .------`-\00/-'
                                                      /  ##  ## (oo)
                                                      / \## __   ./
                                                         |//YY \|/
                                                         |||   |||";

            Console.WriteLine(cow);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" ");
        }


        public override void Speak()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");
            Console.WriteLine("============= ");
            Console.WriteLine(" Annabelle ");
            Console.WriteLine("============= ");
            Console.WriteLine(" ");



            Console.WriteLine("1. My name is Annabelle " +
                "the cow, my grandfather was a knight" +
                " and his name was 'Sir Loin'.");
            
            
            Console.WriteLine(" ");
        
        }

        public override void Eat()
        {

            Console.WriteLine("2. There's nothing quite so yummy as warm milk from my muuummy!'");
            Console.ReadLine();
            
            Console.WriteLine(" ");
        }

        public override void Move()
        {
            Console.WriteLine("3. Run human, remember that more people are attacked by cows rather than sharks.");
            Console.ReadLine();
           
            Console.WriteLine(" ");

        }

        public override void Sleep()
        {
            Console.WriteLine("4. My mauumy said it's pasture bedtime.");
            Console.ReadLine();
           
            Console.WriteLine(" ");
            Console.ResetColor();

        }
    }
}
