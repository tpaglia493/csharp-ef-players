﻿using csharp_ef_players;

bool go = true;   
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("0. Exit");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Search and print a player by Id");
Console.WriteLine("3. Search and print a player by its Name and Surname");
Console.WriteLine("4. Modify player's number of matches and score by player Id");
Console.WriteLine("\n-------------------\n");
while (go) { 
 

    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response) 
    {
        case 0:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;
        case 1:
            Console.Write("Insert the name of the player: ");
            string playerName = Console.ReadLine();
            Console.Write("Insert the surname : ");
            string playerSurname = Console.ReadLine();
            using(SportContext db = new SportContext())
            {
                Random random = new Random();

                double randomScore = random.NextDouble() * (9) + 1;
                int randomNumberOfMatches = random.Next(1, 101);            
                int randomNumberOfVicories = random.Next(1, randomNumberOfMatches);
               

                Player newPlayer = new Player(playerName, playerSurname, randomNumberOfMatches,randomNumberOfVicories,randomScore);
                db.Add(newPlayer);
                db.SaveChanges();
            }
            break;

        case 2:
            Console.Write("Insert the Id to search: "); 
            int playerIdToSearch = int.Parse(Console.ReadLine());
            
            using (SportContext db = new SportContext())
            {
                Player playerFound = db.Player.Where(player => player.Id == playerIdToSearch).First();
                Console.WriteLine(playerFound);
            }
            break;

        case 3:
          
            Console.Write("Insert the name of the player you want to search:");
            string playerNameToSearch = Console.ReadLine();
            Console.Write("Insert the surname of the player you want to search : ");
            string playerSurnameToSearch = Console.ReadLine();
            using (SportContext db = new SportContext())
            {
                Player playerFound = db.Player.Where(player => player.Name == playerNameToSearch && player.Surname == playerSurnameToSearch).First();
                Console.WriteLine(playerFound.ToString());
            }
            break;
        
        case 4:
            Console.Write("Insert the Id to search: ");
            int playerIdToModify = int.Parse(Console.ReadLine());
            
            using (SportContext db = new SportContext())
            {
                if (db.Player.Where(player => player.Id == playerIdToModify).Any())
                {
                    Player playerToModify = db.Player.Where(player => player.Id == playerIdToModify).First();
                    Console.Write("Insert the new number of matches: ");
                    int newNumberOfMatches = int.Parse(Console.ReadLine());
                    
                    Console.Write("Insert the new score: ");
                    int newPlayerScore = int.Parse(Console.ReadLine());
                    
                    playerToModify.NumberOfPlayedMatches = newNumberOfMatches;
                    playerToModify.Score = newPlayerScore;
                    
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No player with Id #{playerIdToModify} was found. ");
                }

            }
            break;

        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}