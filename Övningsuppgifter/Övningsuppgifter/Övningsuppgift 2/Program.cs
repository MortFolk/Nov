#region WHAT TO IMPLEMENT

/* IDEA

MAIN MENU

-------------------------------------------------------------------
Welcome admin

Type what you would like to do
Add person: *Add*
"Type the persons name"
    *name*
"Type persons age"
    *age*

Remove person: *Remove*
    *shows list*
"Who would you like to remove?"
    *type name*
"Are you sure?"
    *Y/N*

See persons: See
    *shows list*
  */

#endregion

#region START PROGRAM

//Welcomes on start of program
{
    Console.WriteLine("Main menu");
    Console.WriteLine("_____________________");
    Console.WriteLine("Welcome admin\n");
    Console.ReadKey();
    Console.WriteLine("Welcome admin\n");


    Console.WriteLine("\nView List: View");
    Console.WriteLine("Add Person: Add");
    Console.WriteLine("Remove Person: Remove");


    Console.ReadKey();
}
#endregion

Console.ReadLine();


string AddPerson = "Add";
string RemovePerson = "Remove";
string ViewList = "View";


