// See https://aka.ms/new-console-template for more information

string menuSelect = DisplayMenu();
MenuOutput(menuSelect);


static string DisplayMenu()
{
    string userSelection = "";
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
    userSelection = Console.ReadLine();
    return userSelection;
}

static void MenuOutput(string menuSelect)
{
    if(menuSelect == "1")
    {
        int ran = new Random().Next(2,10);
        for (int i = 1; i <= ran ; i++)
        {
           for (int j = 1; j <= i; j++) 
           {
               System.Console.Write("0");
           }
            System.Console.Write("\n");
        }
    }
    else if(menuSelect == "2")
    {
        int ran = new Random().Next(2,10);
        for (int i = 1; i <= ran ; i++)
        {
           for (int j = 1; j <= i; j++)
           {
                int space = new Random().Next(2);
                if (space == 1)
                {
                System.Console.Write("0");
                }
                else if(space == 0)
                {
                System.Console.Write(" ");
                }    
           }
           System.Console.Write("\n");
        }
    }
    
     else if(menuSelect == "3")
    {
       System.Console.WriteLine("Good Bye!");
    }
    else
    {
        System.Console.WriteLine("Invalid choice!");
        DisplayMenu();
    }
}
    
// Tried to run method InvalidEntry; continued getting error "not all code paths ruturn value"

// static string InvalidEntry(string menuSelect)
// {
//     while (menuSelect != "3" && menuSelect != "2" && menuSelect != "1")
//     {
//         string newChoice = "";
//         System.Console.WriteLine("Invalid choice");
//         System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
//         newChoice = Console.ReadLine();
//         return newChoice;


//     }
// }


