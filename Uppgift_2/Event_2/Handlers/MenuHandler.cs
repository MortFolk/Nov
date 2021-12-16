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

            Console.WriteLine("---------------------");
            Console.WriteLine("---   Add user    ---");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            var participant = new Participant();
            
            Console.Write("First Name: ");
            participant.FirstName = Console.ReadLine() ?? "";
            
            Console.Write("Last Name: ");
            participant.LastName = Console.ReadLine() ?? "";
           
            Console.Write("Email: ");
            participant.Email = Console.ReadLine() ?? "";
            participant.Id = Guid.NewGuid();

            ListHandler.AddUser(participant);
            Console.WriteLine($"\nUser {participant.FullName} with the id {participant.Id} was added to the list");
            Task.Delay(0500).Wait();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }


        public static void MenuOption_Remove()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("---  Remove user  ---");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.Write("Enter the ID of the User to delete: ");
            
            var id = Console.ReadLine();

      
            
            ListHandler.RemoveUser(id);

            Console.WriteLine($"User wih id {id} was removed from the list");

            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MenuOption_ShowUser()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("---     Users     ---");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            foreach(var participant in ListHandler.GetParticipants())
                Console.WriteLine($"ID: {participant.Id} Name: {participant.FullName} Email: {participant.Email}");
            
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MenuOption_Save()
        {

        }

    }
}
