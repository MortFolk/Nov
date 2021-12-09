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

View persons: View
    *shows list*
  */

#endregion

#region START PROGRAM

//Welcomes on start of program
using Ovning_1;
    Console.WriteLine("Main menu");
    Console.WriteLine("_____________________");
    Console.WriteLine("Welcome admin\n");
    Console.ReadKey();
 

    Console.WriteLine("\nView List: View");
    Console.WriteLine("Add Person: Add");
    Console.WriteLine("Remove Person: Remove");
    Console.WriteLine("Save List: Save");
    Console.Write("\nType what you want to do: ");

#endregion

#region List!



//List<Customer> customer = new();




    //"menuOption" determines where you go, i guess...
    string menuOption = Console.ReadLine();

    if (menuOption == "View")
    Console.WriteLine("ayoooooooo!!!!!!!!!!!!!!");   
    Console.ReadKey();

#endregion



#region ADD/add person to list

    if (menuOption == "Add")
{
    Console.Write("Type the persons full name: ");
    string Name1 = Console.ReadLine();  //Can probably change this?
    Console.Write("Type the persons age: ");
    int Age1 = int.Parse(Console.ReadLine());
    Console.Write("Type the persons Email: ");
    string Email1 = Console.ReadLine();
    Console.Write(Name1 + " " + Age1 + " " + Email1);
}
    //Same as above just lowercase "add"
    if (menuOption == "add")
    {
    Console.Write("Type the persons name: ");
    string Name1 = Console.ReadLine();
    Console.Write("Type the persons age: ");
    int Age1 = int.Parse(Console.ReadLine());
    Console.Write("Type the persons Email: ");
    string Email1 = Console.ReadLine();
    Console.Write(Name1 + " " + Age1 + " " + Email1);
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






