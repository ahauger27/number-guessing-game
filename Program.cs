Random random = new Random();

string[] previousGuesses = new string[10];

Console.WriteLine("I'm thinking of a number between 1 and 100...");
Console.WriteLine("You have 10 guesses to get the right answer.");

PlayGame();

Console.WriteLine("Game Over");

void PlayGame()
{
    int guessNumber = 1;
    var answer = GetRandomAnswer();

    for (int i = 0; i < previousGuesses.Length; i++)
    {
        if (guessNumber == 10)
        {
            Console.WriteLine("Final Guess:");
        }
        else
        {
            Console.WriteLine($"Guess #{guessNumber}:");
        }
        
        var guess = GetUserGuess();

        previousGuesses[i] = CheckGuess(guess, answer);
        Console.WriteLine(previousGuesses[i]);
        Console.WriteLine("");
        
        if (previousGuesses.Contains("Correct!"))
        {
            Console.WriteLine("You Win!");
            return;
        }
        
        guessNumber ++;
    }
}

string CheckGuess(int guess, int answer)
{
    // Compare guess to answer
    if (guess < answer)
    {
        return "Too low";
    }
    else if (guess > answer)
    {
        return "Too high";
    }
    else
    {
        return "Correct!";
    }
}

int GetRandomAnswer()
{
    return random.Next(0, 101);
}

int GetUserGuess()
{
    string response = Console.ReadLine();
    return int.Parse(response);
}