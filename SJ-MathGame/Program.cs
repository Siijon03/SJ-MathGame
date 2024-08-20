using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static string userName; // Make userName a static field
    public static List<string> gamesPlayed = new List<string>();

    static void Main()
    {
        Console.WriteLine("Hello! What is your Name?");
        userName = Console.ReadLine();

        // We can get the current date and time.
        var date = DateTime.Today;
        Console.WriteLine(date);

        int index = 1;
        Menu(ref index);
    }

    // Using our Menu into a Method.
    static void Menu(ref int index)
    {
        bool isGameOn = true;

        while (isGameOn)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            string myParagraph = $@"
Hello {userName}, What would you like to play?
{index++}.  Addition
{index++}.  Subtraction
{index++}.  Division
{index++}.  Multiplication
{index++}.  View Previous Games
{index++}.  Quit the Game
";
            Console.WriteLine(myParagraph);
            Console.WriteLine("-----------------------------------------------");

            // Reset the index to 1 for the next menu display
            index = 1;

            if (!int.TryParse(Console.ReadLine(), out int userChoice) || userChoice < 1 || userChoice > 6)
            {
                Console.WriteLine("Invalid input. Please select a number between 1 and 6.");
                continue; // Prompt the menu again
            }

            switch (userChoice)
            {
                case 1:
                    Thread.Sleep(1000);
                    AdditionGame();
                    break;

                case 2:
                    Thread.Sleep(1000);
                    SubtractionGame();
                    break;

                case 3:
                    Thread.Sleep(1000);
                    DivisionGame();
                    break;

                case 4:
                    Thread.Sleep(1000);
                    MultiplicationGame();
                    break;

                case 5:
                    Thread.Sleep(1000);
                    ViewPrevGames();
                    break;

                case 6:
                    Console.WriteLine("See you Later!");
                    Thread.Sleep(1000);
                    isGameOn = false; // Exit the loop
                    break;

                default:
                    Console.WriteLine("Unknown Command, Please Try Again.");
                    break;
            }
        }
    }

    static void AdditionGame()
    {
        Console.WriteLine("Addition Selected");

        var randomNum = new Random();
        int firstNum;
        int secondNum;

        int totalScore;
        Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        Console.Clear();

        for (int i = 0; i < totalScore; i++)
        {
            firstNum = randomNum.Next(1, 20);
            secondNum = randomNum.Next(1, 20);

            Console.WriteLine($"{questionIndex++}. What is {firstNum} + {secondNum} ?");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum + secondNum)
            {
                Console.WriteLine($"Well done {userName} Your Answer was Correct!");
                score++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        Console.WriteLine("\n Press Any Key To Return to Menu.");
        Console.ReadLine();

        // Log the game played
        gamesPlayed.Add($"Addition Game: {score}/{totalScore} at {DateTime.UtcNow}");
    }

    static void SubtractionGame()
    {
        Console.WriteLine("Subtraction Selected");

        var randomNum = new Random();
        int firstNum;
        int secondNum;

        int totalScore;
        Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        Console.Clear();

        for (int i = 0; i < totalScore; i++)
        {
            firstNum = randomNum.Next(1, 20);
            secondNum = randomNum.Next(1, 20);

            Console.WriteLine($"{questionIndex++}. What is {firstNum} - {secondNum} ?");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum - secondNum)
            {
                Console.WriteLine($"Well done {userName} Your Answer was Correct!");
                score++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        Console.WriteLine("\n Press Any Key To Return to Menu.");
        Console.ReadLine();

        // Log the game played
        gamesPlayed.Add($"Subtraction Game: {score}/{totalScore} at {DateTime.UtcNow}");
    }

    static void DivisionGame()
    {
        Console.WriteLine("Division Selected");

        int totalScore;
        Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        Console.Clear();

        for (int i = 0; i < totalScore; i++)
        {
            var divisionNumbers = GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{questionIndex++}. What is {firstNumber} / {secondNumber} ?");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine($"Well done {userName} Your Answer was Correct!");
                score++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        Console.WriteLine("\n Press Any Key To Return to Menu.");
        Console.ReadLine();

        // Log the game played
        gamesPlayed.Add($"Division Game: {score}/{totalScore} at {DateTime.UtcNow}");
    }

    static void MultiplicationGame()
    {
        Console.WriteLine("Multiplication Selected");

        var randomNum = new Random();
        int firstNum;
        int secondNum;

        int totalScore;
        Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        Console.Clear();

        for (int i = 0; i < totalScore; i++)
        {
            firstNum = randomNum.Next(1, 20);
            secondNum = randomNum.Next(1, 20);

            Console.WriteLine($"{questionIndex++}. What is {firstNum} * {secondNum} ?");
            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum * secondNum)
            {
                Console.WriteLine($"Well done {userName} Your Answer was Correct!");
                score++;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        Console.WriteLine("\n Press Any Key To Return to Menu.");
        Console.ReadLine();

        // Log the game played
        gamesPlayed.Add($"Multiplication Game: {score}/{totalScore} at {DateTime.UtcNow}");
    }

    static void ViewPrevGames()
    {
        Console.Clear();
        Console.WriteLine("Previous Games Played:");
        if (gamesPlayed.Count == 0)
        {
            Console.WriteLine("No games have been played yet.");
        }
        else
        {
            foreach (var game in gamesPlayed)
            {
                Console.WriteLine(game);
            }
        }
        Console.WriteLine("\nPress Any Key To Return to Menu.");
        Console.ReadLine();
    }

    static int[] GetDivisionNumbers()
    {
        var random = new Random();
        int firstNum = random.Next(1, 99);
        int secondNum = random.Next(1, 99);

        while (firstNum % secondNum != 0)
        {
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);
        }

        return new int[] { firstNum, secondNum };
    }
}
