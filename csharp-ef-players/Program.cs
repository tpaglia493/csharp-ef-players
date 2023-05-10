bool go = true;
while (go)
{
    Console.WriteLine("------- MENU -------\n");
    Console.WriteLine("1. Insert a new player");
    Console.WriteLine("2. Insert a team");
    Console.WriteLine("3. Esci");
    Console.WriteLine("\n-------------------");

    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 1:
            Console.Write("Inserisci il nome della software house: ");
            string nameSoftwareHouse = Console.ReadLine();
​
            Console.WriteLine("Inserisci la partita IVA : ");
            string vatNumber = Console.ReadLine();
​
            Console.WriteLine("Inserisci la descrizione della software house : ");
            string softwareHouseDescription = Console.ReadLine();
​
            
            break;
​
        case 2:
            Console.WriteLine("Inserisci il nome : ");
            string name = Console.ReadLine();
​
            Console.WriteLine("Inserisci la data di pubblicazione (yyyy-mm-dd) : ");
            DateTime releaseDate = DateTime.Parse(Console.ReadLine());
​
            Console.WriteLine("Inserisci l'id della software house che lo ha prodotto: ");
            int softwareHouseId = int.Parse(Console.ReadLine());
​
            break;

        case 3:
            Console.WriteLine("Grazie e arrivederci!");
            go = false;
            break;
        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}