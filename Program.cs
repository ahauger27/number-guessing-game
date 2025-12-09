Random random = new Random();

// initialize an array of length 10 to track guesses
string[] previousGuesses = new string[10];
// this array will store strings such as "too low" or "too high"
// once this array is full of guesses, the game is over and the player has lost

Console.WriteLine("I'm thinking of a number between 1 and 100...");
Console.WriteLine("You have 10 guesses to get the right answer.");

PlayGame();

void PlayGame()
{
    int guessNumber = 1;
    var answer = GetRandomAnswer();

    for (int i = 0; i < previousGuesses.Length; i++)
    {
        if (guessNumber == 10)
        {
            Console.WriteLine("Final Guess:")
        }
        else
        {
            Console.WriteLine($"Guess #{guessNumber}:");
        }
        
        var guess = GetUserGuess();
        previousGuesses[i] = CheckGuess(guess, answer);
        Console.WriteLine(previousGuesses[i]);
        Console.WriteLine("");
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