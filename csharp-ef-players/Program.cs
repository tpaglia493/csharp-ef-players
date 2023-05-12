using csharp_ef_players;

bool go = true;   
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("0. Exit");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Search and print a player by Id");
Console.WriteLine("3. Search and print a player by Name and Surname");
Console.WriteLine("4. Modify player's number of matches and score by player Id");
Console.WriteLine("5. Remove a player by Id");
Console.WriteLine("6. Insert a new team");
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
            Console.Write("Insert the Id of the player's team:");
            int playerTeamId = int.Parse(Console.ReadLine());


            using (SportContext db = new SportContext())
            {
                if(db.Team.Where(team => team.TeamId == playerTeamId).Any()) { 
                Random random = new Random();

                double randomScore = random.NextDouble() * (9) + 1;
                int randomNumberOfMatches = random.Next(1, 101);            
                int randomNumberOfVicories = random.Next(1, randomNumberOfMatches);
               

                Player newPlayer = new Player(playerName, playerSurname, randomNumberOfMatches,randomNumberOfVicories,randomScore,playerTeamId);
                db.Add(newPlayer);
                db.SaveChanges();
                }
                else 
                { 
                    Console.WriteLine($"There's no team with id #{playerTeamId}");
                  
                
                }
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
            Console.Write("Insert the surname of the player you want to search: ");
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

            case 5:
            Console.WriteLine("insert the Id of the player you want to remove");
            int playerIdToRemove = int.Parse(Console.ReadLine());
            using(SportContext db = new SportContext())
            {
                Player playerToRemove = db.Player.Where(p => p.Id == playerIdToRemove).First();
                db.Player.Remove(playerToRemove);
                db.SaveChanges() ;

            }
            break;
            case 6:
            Console.Write("Insert the name of the Team: ");
            string teamName = Console.ReadLine();
            Console.Write("Insert the city of the Team: ");
            string teamCity = Console.ReadLine();
            Console.Write("Insert the colors of the Team: ");
            string teamColors = Console.ReadLine();
            Console.Write("Insert the Trainer of the Team: ");
            string teamTrainer = Console.ReadLine();
            using(SportContext db = new SportContext())
            {
                Team newTeam = new Team(teamName, teamCity, teamTrainer, teamColors);

                db.Add(newTeam); 
                db.SaveChanges();

            }
            break;
        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}