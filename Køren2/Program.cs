using System;
using System.Collections.Generic;

namespace Køren2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a asignment for school
            //variables to make the users and check if the program is terminatet
            string name;

            bool clocked = false;

            //make the object from the Menu class
            Menu menu = new Menu();

            //makes the queue
            Queue<UserClass> queue = new Queue<UserClass>();

            //make a loop to keep the program going

            do
            {
                //call the methood in the Menu call
                //the queue.Count is added in the () to send the number of users in the queue, to the int users, in the Menu class 
                menu.userMenu(queue.Count);

                //first i tried whit a ReadKey() command, but i cant make it work
                //therefore the ReadLine(), even though the user will have to hit an extra key
                int choice = int.Parse(Console.ReadLine());

                //a switch to read the input from the user
                switch (choice)
                {
                    //if the user presses 1
                    //the work starts whit createing a new user
                    //add the user to the queue
                    case 1:

                        //cler the console
                        Console.Clear();

                        //ask for the new users name
                        //reads the input
                        Console.WriteLine("Please enter the users name.");
                        name = Console.ReadLine();

                        //turns the new user into an object
                        UserClass user = new UserClass(name);

                        //add the object/new user in the queue
                        queue.Enqueue(user);

                        //breaks out
                        break;

                    //if the user presses 2
                    //the first user in the queue is displayed
                    case 2:

                        //cler the console
                        Console.Clear();

                        //display the next user in the queue
                        Console.WriteLine("The next person to use the lavatory is: " + queue.Peek());

                        //output to the user
                        //makes a free line and
                        //informs how to get back to the menu
                        Console.WriteLine();
                        Console.WriteLine("For returning to the menu, please press Enter");
                        Console.WriteLine();

                        //breaks out
                        break;

                    //if the user presses 3
                    //all the users in the queue is displayed
                    case 3:

                        //cler the console
                        Console.Clear();

                        //first output
                        Console.WriteLine("Waiting in the queue is:");
                        Console.WriteLine();

                        //loops though the queue and outputs the names
                        foreach (UserClass u in queue)
                        {
                            Console.WriteLine(u);
                        }

                        //output to the user
                        //makes a free line and
                        //informs how to get back to the menu
                        Console.WriteLine();
                        Console.WriteLine("For returning to the menu, please press Enter");
                        Console.WriteLine();

                        //breaks out
                        break;

                    case 4:

                        //set the bool clocked to true, and terminate the program
                        clocked = true;

                        //breaks out
                        break;

                    //default 
                    default:
                        break;
                }

                //the loop runs untill the do/while == true, and the lavatory is clocked
            } while (!clocked);
        }

    }
}
