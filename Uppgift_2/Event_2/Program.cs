

using Event_2.Models;
using Event__2.Handlers;


int Option = -1;

do
{
    Option = MenuHandler.ShowMenu();
    Console.Clear();

    switch (Option)
    {
        case 1: MenuHandler.MenuOption_Create();
            Task.Delay(1500).Wait();
            break;

        case 2: MenuHandler.MenuOption_Remove();
            Task.Delay(1500).Wait();
            break;

        case 3: MenuHandler.MenuOption_ShowUser();
            Task.Delay(1500).Wait();
            break;

        case 4: FileHandler.SaveToFile();
            Task.Delay(1500).Wait();
            break;
        default:
            break;
    }
}
while (Option != 0);






