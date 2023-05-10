using csharp_ef_players;

bool go = true;   
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Insert a team");
Console.WriteLine("3. Esci");
Console.WriteLine("\n-------------------\n");
while (go) { 
 

    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response) 
    { 
            case 1:
            Console.Write("Insert the name of the player: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Insert the surname : ");
            string playerSurname = Console.ReadLine();
            using(SportContext db = new SportContext())
            {
                Player newPlayer = new Player(playerName, playerSurname);

                Random random = new Random();

                double randomDecimal = random.NextDouble() * (10 - 1) + 1;
                newPlayer.Score = randomDecimal;

            
                ushort randomNumberOfMatches = (ushort)random.Next(1, 101);
                newPlayer.NumberOfPlayedMatches = randomNumberOfMatches;

                Random randomNumberOfVicotriesGenerator = new Random();
                ushort randomNumberOfVicories = (ushort)random.Next(1, randomNumberOfMatches);


                db.Add(newPlayer);
                db.SaveChanges();
            }
            break;

        case 2:
            Console.WriteLine(" - Still working on it\n - we'll keep you updated ");
            break;

        case 3:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;

        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}