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

//using Fundamentals_2;

Console.WriteLine("Main menu");
Console.WriteLine("_____________________");
Console.WriteLine("Welcome admin\n");
Console.ReadKey();

Console.WriteLine("\nView List: View");
Console.WriteLine("Add Person: Add");
Console.WriteLine("Remove Person: Remove");
Console.WriteLine("Save List: Save");
Console.WriteLine("Get coupon code: Code");
Console.Write("\nType what you want to do: ");

//"menuOption" determines where you go, i guess...
string menuOption = Console.ReadLine();

#endregion

#region List!
//tried to make a custom List
//using Fundamentals_2;

//Fundamentals_2 är sökvägen där Customers filen ligger
//"customer" är namnet på listan nät den ska refereras
List<Fundamentals_2.Customers> customer = new();

foreach (Fundamentals_2.Customers customers in customer)
    Console.WriteLine(customer);
 

//var Customer = new List<string>();
/*if (menuOption == "View")
{ 
    foreach(var Customer in Customer)
        Console.WriteLine("")

    Console.WriteLine("ayoooooooo!!!!!!!!!!!!!!");
    Console.ReadKey();
}
*/
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
    Console.Write(Name1 + " " + Email1);

    customer.Add(new Fundamentals_2.Customers { Name1 = $"{ Name1 }", Email1 = $"{ Email1 }" });
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



