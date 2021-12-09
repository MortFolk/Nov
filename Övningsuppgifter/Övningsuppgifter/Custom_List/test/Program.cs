//tried to make a custom List
//using Fundamentals_2;

//Fundamentals_2 är sökvägen där Customers filen ligger
//"customer" är namnet på listan nät den ska refereras
List<test.Customers> customer = new();

foreach (test.Customers customers in customer)
    Console.WriteLine(customer);

foreach (test.Customers customers in customer)
    Console.WriteLine(customer);

Console.ReadKey();

customer.Add(new test.Customers { Name1 = "peter", Email1 = "peter.com" });


Console.ReadKey();

//customer.Add(new Custom_List.Customers_list_test.Customers Name1 = "", Email1 = "");

