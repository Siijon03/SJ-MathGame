using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Timers;

class Program
{
    //Make Username Accessible Everywhere within this Class.
    private static string userName;
    //Create A List to Use. 
    public static List<string> gamesPlayed = new List<string>();

    //Developer's Note: Commenting For the Addition Game Applies to the Other Games.
    static void Main()
    {

        //General Greeting
        Console.WriteLine("Hello! What is your Name?");
        //Allows for User to Input Their Own Name.
        userName = Console.ReadLine();

        // We can get the current date and time.
        var date = DateTime.Today;
        Console.WriteLine(date);

        //Establish an Index Value to Iterate. 
        int index = 1;
        Menu(ref index);
    }

    // Using our Menu into a Method.
    static void Menu(ref int index)
    {
        //This is a Boolean.
        bool isGameOn = true;

        //While the Game is Still On, We will go back to this Menu. 
        while (isGameOn)
        {
            //Clear Console to Clean UI Mess. 
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

            //Values of Valid Inputs to Prevent Crashing. 
            if (!int.TryParse(Console.ReadLine(), out int userChoice) || userChoice < 1 || userChoice > 6)
            {
                Console.WriteLine("Invalid input. Please select a number between 1 and 6.");
                continue; // Prompt the menu again
            }

            //Switch Case as to allow for easier code to read. 
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

        // Establish our Variables Needed.
        var randomNum = new Random();
        int firstNum;
        int secondNum;

        int totalScore;

        // This allows the user to choose how many questions they want.
        Console.WriteLine("How many questions would you like? (Type it out in integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        // Due to using random values, they can customize the level of difficulty.
        // Using Do While Loops, We can Constantly Check if the User is Inputting a Number Greater than Zero.
        // We Need Valid Input Checks as to Prevent Crashing Within Our Application.
        int firstRan;
        do
        {
            Console.WriteLine("What is your first random number limit? (Must be greater than 0)");
            firstRan = int.Parse(Console.ReadLine());
            if (firstRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (firstRan <= 0);

        int secondRan;
        do
        {
            Console.WriteLine("What is your second random number limit? (Must be greater than 0)");
            secondRan = int.Parse(Console.ReadLine());
            if (secondRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (secondRan <= 0);

        // Clean Console.
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        // Start a stopwatch to time how long the user takes to finish the game.
        var stopwatch = Stopwatch.StartNew();

        // Using a for loop that will keep going until it meets the specified number of questions.
        for (int i = 0; i < totalScore; i++)
        {
            // Plug in the custom values.
            firstNum = randomNum.Next(1, firstRan);
            secondNum = randomNum.Next(1, secondRan);

            // Display the randomly generated numbers.
            Console.WriteLine($"{questionIndex++}. What is {firstNum} + {secondNum}?");
            var result = Console.ReadLine();

            // If the user's answer is correct.
            if (int.Parse(result) == firstNum + secondNum)
            {
                Console.WriteLine($"Well done {userName}, your answer was correct!");
                // Add a point to their score.
                score++;
                Console.WriteLine();
            }
            // If the user's answer was wrong.
            else
            {
                Console.WriteLine($"Sorry {userName}, your answer was incorrect!");
                Console.WriteLine();
            }
        }

        // Once the for loop condition is satisfied, stop the timer.
        stopwatch.Stop();

        // Print out the final score.
        Console.WriteLine($"Game over {userName}!! Your final score is {score} out of {totalScore}");
        Console.WriteLine($"\nThis game took you {stopwatch.Elapsed:mm\\:ss}");
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadLine();

        // Resets console text color back to white.
        Console.ResetColor();

        // Log the player's score.
        gamesPlayed.Add($"Addition Game: {score}/{totalScore} at {DateTime.UtcNow}");
        gamesPlayed.Add($"This game took you {stopwatch.Elapsed:mm\\:ss}");
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

        // Due to using random values, they can customize the level of difficulty.
        int firstRan;
        do
        {
            Console.WriteLine("What is your first random number limit? (Must be greater than 0)");
            firstRan = int.Parse(Console.ReadLine());
            if (firstRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (firstRan <= 0);

        int secondRan;
        do
        {
            Console.WriteLine("What is your second random number limit? (Must be greater than 0)");
            secondRan = int.Parse(Console.ReadLine());
            if (secondRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (secondRan <= 0);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;

        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < totalScore; i++)
        {
            firstNum = randomNum.Next(1, firstRan);
            secondNum = randomNum.Next(1, secondRan);

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
        Console.ResetColor();

        // Log the game played
        gamesPlayed.Add($"Subtraction Game: {score}/{totalScore} at {DateTime.UtcNow}");
        gamesPlayed.Add($"This Game Took you {stopwatch.Elapsed:mm\\:ss}");
    }

    static void DivisionGame()
    {
        Console.WriteLine("Division Selected");

        int totalScore;
        Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
        totalScore = int.Parse(Console.ReadLine());
        int score = 0;
        int questionIndex = 1;

        // Due to using random values, they can customize the level of difficulty.
        int ranNum;
        do
        {
            Console.WriteLine("What is your first random number limit? (Must be greater than 0)");
            ranNum = int.Parse(Console.ReadLine());
            if (ranNum <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (ranNum <= 0);

        int ranNum2;
        do
        {
            Console.WriteLine("What is your second random number limit? (Must be greater than 0)");
            ranNum2 = int.Parse(Console.ReadLine());
            if (ranNum2 <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (ranNum2 <= 0);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;

        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < totalScore; i++)
        {
            //Passing Through Our Custom Number's Into the 'GetDivisionNumbers' Function.
            var divisionNumbers = GetDivisionNumbers(ranNum, ranNum2);
            //Getting Our First and Second Numbers within the Array.
            //Arrays start from a 0 index (0,1,2 etc)
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
        Console.ResetColor();

        // Log the game played
        gamesPlayed.Add($"Division Game: {score}/{totalScore} at {DateTime.UtcNow}");
        gamesPlayed.Add($"This Game Took you {stopwatch.Elapsed:mm\\:ss}");
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

        // Due to using random values, they can customize the level of difficulty.
        int firstRan;
        do
        {
            Console.WriteLine("What is your first random number limit? (Must be greater than 0)");
            firstRan = int.Parse(Console.ReadLine());
            if (firstRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (firstRan <= 0);

        int secondRan;
        do
        {
            Console.WriteLine("What is your second random number limit? (Must be greater than 0)");
            secondRan = int.Parse(Console.ReadLine());
            if (secondRan <= 0)
            {
                Console.WriteLine("Invalid input. The number must be greater than 0.");
            }
        } while (secondRan <= 0);


        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < totalScore; i++)
        {
            firstNum = randomNum.Next(1, firstRan);
            secondNum = randomNum.Next(1, secondRan);

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
        Console.ResetColor();

        // Log the game played
        gamesPlayed.Add($"Multiplication Game: {score}/{totalScore} at {DateTime.UtcNow}");
        gamesPlayed.Add($"This Game Took you {stopwatch.Elapsed:mm\\:ss}");
    }

    static void ViewPrevGames()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Previous Games Played:");

        //If there are No Games Played within the List.
        if (gamesPlayed.Count == 0)
        {
            Console.WriteLine("No games have been played yet.");
        }
        else
        {
            //Foreach Game Logged in the List.
            //Display it.
            foreach (var game in gamesPlayed)
            {
                Console.WriteLine(game);
            }
        }
        Console.WriteLine("\nPress Any Key To Return to Menu.");
        Console.ReadLine();
        Console.ResetColor();
    }

    //Using The Preestablished numbers within the Main Game function and Passing them through into this.
    static int[] GetDivisionNumbers(int ranNum, int ranNum2)
    {
        //Create a Random Variable.
        var random = new Random();
        //Using Custom Numbers, Random Numbers are Generated Between 1 and Our Custom Limit.
        int firstNum = random.Next(1, ranNum);
        int secondNum = random.Next(1, ranNum2);

        //If the Numbers do not have a Remainder (0.333333 For Example) Then Use Those.
        while (firstNum % secondNum != 0)
        {
            firstNum = random.Next(1, ranNum);
            secondNum = random.Next(1, ranNum2);
        }

        //Return those Found Integers. 
        return new int[] { firstNum, secondNum };
    }
}
