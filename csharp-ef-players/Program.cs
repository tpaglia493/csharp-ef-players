using System;

bool go = true;   
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Insert a team");
Console.WriteLine("3. Menu");
Console.WriteLine("4. Esci");
Console.WriteLine("\n-------------------");
while (go) { 
 

    Console.Write("\nChoose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response) 
    { 
            case 1:
            Console.Write("Insert the name of the player: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Insert the surname : ");
            string playerSurname = Console.ReadLine();
            break;

        case 2:
            Console.WriteLine(" - Still working on it\n - we'll keep you updated ");
            break;

        case 3:
            Console.WriteLine("------- MENU -------\n");
            Console.WriteLine("1. Insert a new player");
            Console.WriteLine("2. Insert a team");
            Console.WriteLine("3. Menu");
            Console.WriteLine("4. Esci");
            Console.WriteLine("\n-------------------\n");
            break;

        case 4:
            Console.WriteLine("thank you and goodbye");
            go = false;
            break;

        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}