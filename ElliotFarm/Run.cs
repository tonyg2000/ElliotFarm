using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliotFarm
{
    class Run
    {
       public void  RunFarm()
        {
            var MainMenu = new MainMenu();
            var Introduction = new Introduction();
            Introduction.FarmHeader();
            Console.Clear();





            do
            {
                Console.Clear();
                Introduction.FarmMenu();
                MainMenu.Menu();
            } while (true);
            
               
         
               
            
          
           

        }
    }
}
