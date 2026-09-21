class Game
{

    bool isRunning = true;
    Player player = new(2, 0); // player starting positon
    Map map = new();
    Menu menu = new();


    public void Start()
    {
        // Game Sart
        Console.WriteLine("Emporia Amnesia");
        while (isRunning)
        {
            playTurn();
        }
    }

    Location CurrentLocation() // location is an object of type location ( i e toilet stall, Foyer, ...)
    { 
        return map.GetLocation(player.Row, player.Col); // player.row and player.col is the player position - not player location
    } 

    void playTurn()
    {
        Location location = CurrentLocation();

        Console.WriteLine($"\n === {location.Name} ===");
        Console.WriteLine(location.Description);

        // 
        isRunning = false;
    }

}