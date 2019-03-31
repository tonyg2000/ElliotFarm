using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class MainMenu
    {
        public void Menu()
        {
           

          

            ConsoleKeyInfo action;
                action = Console.ReadKey(true);


                var Annabelle = new Cow();
                var Lamber = new Sheep();
                var Porky = new Pig();
                var MrZeBrah = new Horse();
            
            var quit = false;

             
            do
            {

                switch (action.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            Console.Clear();
                            Console.WriteLine("1. Cow Description");
                            Console.WriteLine("2. What's the Cow Name? ");
                            Console.WriteLine("3: What do Annabelle eat?");
                            Console.WriteLine("4: How fast is Annabelle? ");
                            Console.WriteLine("5: When does Annabelle sleep? ");
                            var value = Console.ReadLine();

                            if (value == "1")
                            {
                                Console.Clear();
                                Annabelle.MakeCow();
                              
                            }

                          else  if (value == "2")
                            {
                                Console.Clear();
                                Annabelle.Speak();
                           
                            }

                            else if (value == "3")
                            {
                                Console.Clear();
                                Annabelle.Eat();
                              

                            }

                            else if (value == "4")
                            {
                                Console.Clear();
                              Annabelle.Move();
                

                            }

                            else if (value == "5")
                            {
                                Console.Clear();
                               Annabelle.Sleep();
                         

                            }



                            else
                            {
                                Console.WriteLine("Sorry, Wrong input... choose a number between 1-5.");

                                Console.ReadLine();
                                Console.Clear();
                                
                            }
                            break;
                        }

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        {
                            Console.Clear();
                            Console.WriteLine("1. Sheep Description");
                            Console.WriteLine("2. What's the Sheep Name? ");
                            Console.WriteLine("3. What do Lamber eat?");
                            Console.WriteLine("4. How fast is Lamber? ");
                            Console.WriteLine("5. When does Lamber sleep? ");
                            var value = Console.ReadLine();

                            if (value == "1")
                            {
                                Console.Clear();
                                Lamber.MakeSheep();
                               
                            }

                           else if (value == "2")
                            {
                                Console.Clear();
                                Lamber.Speak();
                             
                            }

                            else if (value == "3")
                            {
                                Console.Clear();
                                Lamber.Eat();
                               

                            }

                            else if (value == "4")
                            {
                                Console.Clear();
                                Lamber.Move();
                             

                            }

                            else if (value == "5")
                            {
                                Console.Clear();
                                Lamber.Sleep();
                             

                            }



                            else
                            {
                                Console.WriteLine("Sorry, Wrong input... choose a number between 1-5.");

                                Console.ReadLine();
                                Console.Clear();
                                Menu();
                            }
                            break;
                        }

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        {
                            Console.Clear();
                            Console.WriteLine("Pig Description");
                            Console.WriteLine("1. What's the Pig Name? ");
                            Console.WriteLine("2: What do Porky eat?");
                            Console.WriteLine("3: How fast is Porky? ");
                            Console.WriteLine("4: When does Porky sleep? ");
                            var value = Console.ReadLine();

                            if (value == "1")
                            {
                                Console.Clear();
                                Porky.MakePig();
                              
                            }

                            else if (value == "2")
                            {
                                Console.Clear();
                                Porky.Speak();
                               
                            }

                            else if (value == "3")
                            {
                                Console.Clear();
                                Porky.Eat();
                               
                            }

                            else if (value == "4")
                            {
                                Console.Clear();
                                Porky.Move();
                              
                            }

                            else if (value == "5")
                            {
                                Console.Clear();
                                Porky.Sleep();
                              
                            }



                            else
                            {
                                Console.WriteLine("Sorry, Wrong input... choose a number between 1-5.");

                                Console.ReadLine();
                                Console.Clear();
                               
                            }
                            break;

                        }

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        {
                            Console.Clear();
                            Console.WriteLine("1. Horse Description");
                            Console.WriteLine("2. What's the Horse Name? ");
                            Console.WriteLine("3. What do Mr. Ze Brah  eat?");
                            Console.WriteLine("4. How fast is Mr. Ze Brah e? ");
                            Console.WriteLine("5. When does Mr. Ze Brah  sleep? ");
                            var value = Console.ReadLine();

                            if (value == "1")
                            {
                                Console.Clear();
                                MrZeBrah.MakeHorse();
                            }


                           else if (value == "2")
                            {
                                Console.Clear();
                                MrZeBrah.Speak();
                            }

                            else if (value == "3")
                            {
                                Console.Clear();
                                MrZeBrah.Eat();

                            }

                            else if (value == "4")
                            {
                                Console.Clear();
                                MrZeBrah.Move();

                            }

                            else if (value == "5")
                            {
                                Console.Clear();
                                MrZeBrah.Sleep();

                            }





                            else
                            {
                                Console.WriteLine("Sorry, Wrong input... choose a number between 1-5.");
                                Console.ReadLine();
                                Console.Clear();
                                
                               Menu();
                            }


                            break;
                        }



                   
                }

            } while (!true);

            quit = true;
            Console.ReadKey();
        }
    }
}
