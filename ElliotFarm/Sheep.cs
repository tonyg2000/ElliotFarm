using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Sheep : Horse
    {
        public virtual void MakeSheep()
        {

            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t=====================================================");
            Console.WriteLine("\t\t\t\t \t\t\tLamber ");
            Console.Write("\t\t\t\t====================================================== ");
            Console.WriteLine(" ");




            string sheep = @"
                                                  .--.
                                                 <|00/>~~~~~~~~\__
                                                  |_/( ' , )  ).)V
                                                      \. ( ')  ,)
                                                       |[/~~~|[/
                                                               ";

            Console.WriteLine(sheep);
            Console.Clear();
            Console.WriteLine("");
        }

        public override void Speak()
        {
            Console.WriteLine(" ");
            Console.WriteLine("============= ");
            Console.WriteLine(" Lamber ");
            Console.WriteLine("============= ");
            Console.WriteLine(" ");

            Console.WriteLine("1. Yep!!! It's me, Lambert the black sheep of the family I'm baaaaaaad...... ");
            Console.Clear();
            Console.WriteLine(" ");
        }

        public override void Eat()
        {

            Console.WriteLine("2.We are better Lawn Mowers Than Goats!'");
            Console.Clear();
            Console.WriteLine(" ");
        }

        public override void Move()
        {
            Console.WriteLine("3.  I'm  fast like a lamborghini.");
            Console.Clear();
            Console.WriteLine(" ");

        }

        public override void Sleep()
        {
            Console.WriteLine("4. I'm in your insomnia swat team. ");
            Console.Clear();
            Console.WriteLine(" ");
            Console.ResetColor();

        }
    }
}
