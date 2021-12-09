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

    Console.WriteLine("Main menu");
    Console.WriteLine("_____________________");
    Console.WriteLine("Welcome admin\n");
    Console.ReadKey();
 

    Console.WriteLine("\nView List: View");
    Console.WriteLine("Add Person: Add");
    Console.WriteLine("Remove Person: Remove");
    Console.Write("\nType what you want to do: ");

#endregion

#region List!




#endregion



#region VIEW List
string menuOption = Console.ReadLine();

if (menuOption == "View")


#endregion

#region ADD/add person to list

if (menuOption == "Add")
{
    Console.Write("Type the persons name: ");
    string Name1 = Console.ReadLine();
    Console.Write("Type the persons age: ");
    int Age1 = int.Parse(Console.ReadLine());
    Console.WriteLine(Name1 + Age1);
}

if (menuOption == "add")
{
    Console.Write("Type the persons name: ");
    string Name1 = Console.ReadLine();
    Console.Write("Type the persons age: ");
    int Age1 = int.Parse(Console.ReadLine());
    Console.WriteLine(Name1 + Age1);
}

#endregion 

#region Remove person from list



#endregion

//else
//{
//}








/*
 string AddPerson = "";
string RemovePerson = "Remove";
string ViewList = "View";
 
 */






