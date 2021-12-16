using Event_2.Handlers;
using Event_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event__2.Handlers
{
    internal class MenuHandler
    {
       
        /// <summary>
        /// Prints the "Main menu"
        /// </summary
        /// <returns>Returns value between 0-4</returns>
        public static int ShowMenu()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("---  Main Menu  ---");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");
            Console.WriteLine("3. Show users");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("0. Quit");
            Console.WriteLine("");
            Console.WriteLine("What do you want to do? 0-4");

            return int.Parse(Console.ReadLine() ?? "-1");

        }

        public static void MenuOption_Create()
        {

            Console.WriteLine("------------------");
            Console.WriteLine("---  Add user  ---");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            var participant = new Participant();
            
            Console.Write("First Name: ");
            participant.FirstName = Console.ReadLine() ?? "";
            
            Console.Write("Last Name: ");
            participant.LastName = Console.ReadLine() ?? "";
           
            Console.Write("Email: ");
            participant.Email = Console.ReadLine() ?? "";

            ListHandler.AddUser(participant);
            Console.WriteLine($"\nUser {participant.FullName} was added to the list");
        }

        public static void MenuOption_Remove()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("---  Remove user  ---");
            Console.WriteLine("---------------------");
            Console.WriteLine("");


        }
        public static void MenuOption_ShowUser()
        {

        }
        public static void MenuOption_Save()
        {

        }

    }
}
