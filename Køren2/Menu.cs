using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køren2
{
    internal class Menu
    {
        //A method to show the menu
        public void userMenu(int users)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("              lavatory Queue: Menu");
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine($"The number of people in the queue is: " + users);
            Console.WriteLine();
            Console.WriteLine("1. Get in the queue");
            Console.WriteLine("2. Who is next");
            Console.WriteLine("3. Who is in the queue");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Please select your choice:");

        }
    }
}
