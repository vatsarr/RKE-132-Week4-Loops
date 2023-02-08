
Random rnd = new Random();
int cpuRand;
bool loopActive = true;

while (loopActive)
{
    cpuRand = rnd.Next(1, 4);

    Console.WriteLine("Guess the number: ");
    int userGuess = Int32.Parse(Console.ReadLine());

    if (userGuess != cpuRand)
    {
        Console.WriteLine("Wrong, try again...");
    }
    else
    {
        Console.WriteLine("Correct, you guessed the number!");
        loopActive = false;
    }
}