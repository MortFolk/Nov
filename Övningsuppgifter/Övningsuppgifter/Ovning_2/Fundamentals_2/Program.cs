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

//START PROGRAM

//Welcomes on start of program

using Fundamentals_2;

Console.WriteLine("Main menu");
Console.WriteLine("_____________________");
Console.WriteLine("Welcome admin\n");
Console.ReadKey();

Console.WriteLine("\nView List: View");
Console.WriteLine("Add Person: Add");
Console.WriteLine("Remove Person: Remove");
Console.WriteLine("Save List: Save list");
Console.WriteLine("Get coupon code: Code");
Console.Write("\nType what you want to do: ");

//"menuOption" determines where you go, i guess...
string menuOption = Console.ReadLine();

//List thingy!

//tried to make a custom List
List<User> Users = new List<User>();
Users.Add(new User("Morten", "morten@mail.com"));


//ADD

if (menuOption == "Add")
{
    Console.Write("Type the persons full name: ");
    string FullName = Console.ReadLine();  //Can probably change this?
    
    Console.Write("Type the persons Email: ");
    string Email = Console.ReadLine();
    Console.WriteLine("User: " + FullName + " Email: " + Email + " has been added!");

    Users.Add(new User("Fullname: " + FullName, "Email: " + Email));

    Console.Write("\nType what you want to do: ");
    menuOption = Console.ReadLine();

}
//Same as above just lowercase "add"
if (menuOption == "add")
{
    Console.Write("Type the persons full name: ");
    string FullName = Console.ReadLine();  //Can probably change this?

    Console.Write("Type the persons Email: ");
    string Email = Console.ReadLine();
    Console.WriteLine("User: " + FullName + " Email: " + Email + " has been added!");

    Users.Add(new User("Fullname: " + FullName, "Email: " + Email));

    Console.Write("\nType what you want to do: ");

    menuOption = Console.ReadLine();
}
    
   

//VIEW

if (menuOption == "View")
{
    foreach(var User in Users)
    {   
        Console.WriteLine($"{User._FullName}, {User._Email} ");
        Console.WriteLine($"{User._FullName}, {User._Email} ");
        Console.WriteLine($"{User._FullName}, {User._Email} ");
    }
   
    Console.Write("\nType what you want to do: ");
    menuOption = Console.ReadLine();
}


//REMOVE
/*
if (menuOption == "Remove")
{
    Console.Write("Type the persons Email: ");
    Email = Console.ReadLine();
}
  
Users.Remove(new User("Fullname: " + FullName, "Email: " + Email));
 */


//Coupon Code!

if (menuOption == "Code")
{
    Guid code = Guid.NewGuid();
    Console.WriteLine(code);

    Console.Write("\nType what you want to do: ");
    Console.ReadLine(); 
}


#region Save list!



#endregion
