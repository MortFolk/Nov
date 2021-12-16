

using Event_2.Models;
using Event__2.Handlers;

Console.WriteLine("Hello world");

MenuHandler.ShowMenu();

int menuOption = -1;

do
{
    menuOption = MenuHandler.ShowMenu();
    switch (menuOption)
    {
        case 1:MenuHandler.MenuOption_Create();
            Task.Delay(2000).Wait();
            break;

        case 2:MenuHandler.MenuOption_Remove();
            break;

        case 3:
            break;

        case 4:
            break;
        default:
            break;
    }
}
while (menuOption != 0);






