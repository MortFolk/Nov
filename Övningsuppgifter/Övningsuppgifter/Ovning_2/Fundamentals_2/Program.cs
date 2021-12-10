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

#endregion

#region List thingy!

//tried to make a custom List
//using Fundamentals_2;


List<User> Users = new List<User>();
Users.Add(new User("Morten", "morten@mail.com"));

#endregion

#region ADD/add person to list

if (menuOption == "Add")
{
    Console.Write("Type the persons full name: ");
    string FullName = Console.ReadLine();  //Can probably change this?
    //Console.Write("Type the persons last name: ");
    //string LastName = (Console.ReadLine());
    Console.Write("Type the persons Email: ");
    string Email = Console.ReadLine();
    //Console.WriteLine("User: " + FullName + /*" " + LastName + */" Email: " + Email + " has been added!");

    Users.Add(new User($"{FullName}, {Email}"));

    Console.Write("\nType what you want to do: ");

    Console.ReadKey();

}

//Same as above just lowercase "add"
if (menuOption == "add")
{
    Console.Write("Type the persons first name: ");
    string FirstName = Console.ReadLine();  //Can probably change this?
    Console.Write("Type the persons last name: ");
    string LastName = (Console.ReadLine());
    Console.Write("Type the persons Email: ");
    string Email = Console.ReadLine();
    Console.WriteLine("User: " + FirstName + " " + LastName + " Email: " + Email + " Has been added!");

    //Name.Add($"{FirstName}{LastName}{Email}");

    Console.Write("\nType what you want to do: ");

    Console.ReadKey();
}

#endregion 

#region View
if (menuOption == "View")
{
    foreach(var User in Users)
    {   
        Console.WriteLine($"{User._FullName}, {User._Email} ");
        Console.WriteLine("Name ");
        Console.WriteLine("Name ");
    }
    Console.ReadKey();
}
#endregion

#region Remove/remove person from list



#endregion

#region Coupon Code!

#endregion

#region Save list!



#endregion
