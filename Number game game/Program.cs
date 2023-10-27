Console.WriteLine("Welcome to the number guesser get the number before the computer figures it out and you win");
string PlayerName = "IDK";
string ComputerName = "Your Mom";
int ComputerMax = 101;
int ComputerMin = 1;
int ComputerGuess = 0;
int exitcode = 0;
Console.WriteLine($"enter your name now or leave Blank for {PlayerName}");
PlayerName = Console.ReadLine();
if  (PlayerName == "")
{
    PlayerName = "IDK";
}
Console.WriteLine($"enter the Computer's name now or leave Blank for {ComputerName}");
ComputerName = Console.ReadLine();
if (ComputerName == "")
{
    ComputerName = "Your Mom";
}
Console.WriteLine("now press any key to begin the game");

Console.ReadKey(true);

Console.WriteLine(".");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");

Random rnd = new Random();
int TheNumber = rnd.Next(1,101);
Console.WriteLine("");
Console.WriteLine("guess any number between 1 and 100");

int playerGuess = int.Parse(Console.ReadLine());
while (true)
{
    if (playerGuess > TheNumber)
    {
        Console.WriteLine("its lower");
        if (playerGuess < ComputerMax)
        {
            ComputerMax = playerGuess;
        }
    }
    else if (playerGuess < TheNumber)
    {
        Console.WriteLine("its higher");
        if (playerGuess > ComputerMin)
        {
            ComputerMin = playerGuess + 1;
        }
    }
    else
    {
        Console.WriteLine($"{PlayerName} Got the number Good job :)");
        Console.WriteLine("enter in 69 to play again");
        if (int.Parse(Console.ReadLine()) != 69)
        {
            Environment.Exit(101);
        }
    }
    if (playerGuess != TheNumber)
    {
        Console.WriteLine($"its {ComputerName}'s Turn Now");
        ComputerGuess = rnd.Next(ComputerMin, ComputerMax);
        Console.Write(".");
        Thread.Sleep(800);
        Console.Write(".");
        Thread.Sleep(800);
        Console.Write(".");
        Thread.Sleep(800);
        Console.WriteLine($"{ComputerName}'s guess is {ComputerGuess}");

        if (ComputerGuess < TheNumber)
        {
            Console.WriteLine("the Number is higher");
            ComputerMin = ComputerGuess + 1;
        }
        else if (ComputerGuess > TheNumber)
        {
            Console.WriteLine("the Number is lower");
            ComputerMax = ComputerGuess;
        }
        if (ComputerGuess != TheNumber)
        {
            Console.WriteLine("Guess your number");

            playerGuess = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine($"{ComputerName} Got the number L + Ratio");
            Console.WriteLine("enter in 69 to play again");
            exitcode = int.Parse(Console.ReadLine());
            if (exitcode != 69)
            {
                Environment.Exit(101);
                exitcode = 0;
            }
            else if (exitcode == 69)
            {
                exitcode = 0;
                TheNumber = rnd.Next(1, 101);
                Console.WriteLine("");
                Console.WriteLine("guess any number between 1 and 100");

                playerGuess = int.Parse(Console.ReadLine());
            }

        }
    }
    else
    {
        TheNumber = rnd.Next(1, 101);
        ComputerMin = 1;
        ComputerMax = 101;
        Console.WriteLine("");
        Console.WriteLine("guess any number between 1 and 100");

        playerGuess = int.Parse(Console.ReadLine());
    }
}