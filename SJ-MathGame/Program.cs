using System.Diagnostics;
using System.Security.Principal;

Console.WriteLine("Hello! What is your Name?");
int index = 1;
int userChoice;
string userName;
var date = DateTime.Today;

//Using Readline, we can take the Username String and use it as an input for our user.
userName = Console.ReadLine();

//We can get the current date and time.
Console.WriteLine(date);

index = Menu(index, userName);

//Using our Menu into a Method. 
static int Menu(int index, string userName)
{
    //With this we can minimise having to write a console.writeline each time and make it into a simple string.
    //Addtionally, Variables such as int, char, bool etc can be printed out by doing {myBool} for example. 
    //The Use of Square Brackets is to avoid having to do "" + userName + ""
    Console.WriteLine("-----------------------------------------------");

    //This is what will allow the Play to Play another game if they wish. 
    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------");
        string myParagraph = $@"
Hello {userName}, What would you like to play?
{index++}.  Addition
{index++}.  Subtraction
{index++}.  Division
{index++}.  Multiplication
5. Quit the Game
";
        Console.WriteLine(myParagraph);
        Console.WriteLine("-----------------------------------------------");
        return index;
    }
    while (isGameOn);
}

//int.parse is so we can take our String Input and Pass it Through as an Integer.
userChoice = int.Parse(Console.ReadLine());

//Using a Switch Statement, We can Make Code that's Easier to Read While still doing the Same as a if/else statment. 
switch (userChoice)
{
    case 1:
        // This is to Delay the Program before Shutting Down.
        Thread.Sleep(1000);
        AdditionGame();
        break;

    case 2:
        // This is to Delay the Program before Shutting Down.
        Thread.Sleep(1000);
        SubtractionGame();
        break;

    case 3:
        // This is to Delay the Program before Shutting Down.
        Thread.Sleep(1000);
        DivisionGame();
        break;

    case 4:
        // This is to Delay the Program before Shutting Down.
        Thread.Sleep(1000);
        MultiplicationGame();
        break;

    case 5:
        Console.WriteLine("See you Later!");
        // This is to Delay the Program before Shutting Down.
        Thread.Sleep(1000);
        Environment.Exit(0);
        break;

    default:
        // In Need of Basic Error Handling.
        Console.WriteLine("Unknown Command, Please Try Again.");
        break;
}

void AdditionGame()
{
    Console.WriteLine("Addition Selected");

    //Using the 'Random' Class, We can Take an Integer and Make it Random.
    var randomNum = new Random();
    int firstNum;
    int secondNum;

    int totalScore;
    Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
    totalScore = int.Parse(Console.ReadLine());
    int score = 0;
    int questionIndex = 1;

    //Using Console.Clear() As to Make the Screen Less Messy.
    Console.Clear();

    //Using a For Loop, We can make it so the Game Continues for 5 Questions instead of 1 Question.
    //We are using a Total Score Variable as it can Allow our Game to be Scalable.
    for (int i = 0; i < totalScore; i++)
    {
        firstNum = randomNum.Next(1, 20);
        secondNum = randomNum.Next(1, 20);

        Console.WriteLine($"{questionIndex++}. What is {firstNum} + {secondNum} ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum + secondNum)
        {
            Console.WriteLine($"Welldone {userName} Your Answer was Correct!");
            //If an Answer is Correct then we can add a point to our total. 
            score++;
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
            Console.WriteLine();

        }

        //We do Four as Iterators start from 0 instead of one, this means the Custom Amount of Iterations (0,1,2,3,4) would have passed.
        if (i == (totalScore - 1))
        {
            Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        }
    }
}
void SubtractionGame()
{
    Console.WriteLine("Subtraction Selected");

    //Using the 'Random' Class, We can Take an Integer and Make it Random.
    var randomNum = new Random();
    int firstNum;
    int secondNum;

    int totalScore;
    Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
    totalScore = int.Parse(Console.ReadLine());
    int score = 0;
    int questionIndex = 1;

    //Using Console.Clear() As to Make the Screen Less Messy.
    Console.Clear();


    //Using a For Loop, We can make it so the Game Continues for 5 Questions instead of 1 Question.
    //We are using a Total Score Variable as it can Allow our Game to be Scalable.
    for (int i = 0; i < totalScore; i++)
    {
        firstNum = randomNum.Next(1, 20);
        secondNum = randomNum.Next(1, 20);

        Console.WriteLine($"{questionIndex++}. What is {firstNum} - {secondNum} ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum - secondNum)
        {
            Console.WriteLine($"Welldone {userName} Your Answer was Correct!");
            //If an Answer is Correct then we can add a point to our total. 
            score++;
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
            Console.WriteLine();

        }

        //We do Four as Iterators start from 0 instead of one, this means the Custom Amount of Iterations (0,1,2,3,4) would have passed.
        if (i == (totalScore - 1))
        {
            Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        }
    }
}
void DivisionGame()
{
    Console.WriteLine("Division Selected");

    int totalScore;
    Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
    totalScore = int.Parse(Console.ReadLine());
    int score = 0;
    int questionIndex = 1;

    //Using Console.Clear() As to Make the Screen Less Messy.
    Console.Clear();

    //Using a For Loop, We can make it so the Game Continues for 5 Questions instead of 1 Question.
    //We are using a Total Score Variable as it can Allow our Game to be Scalable.
    for (int i = 0; i < totalScore; i++)
    {
        //Using this, We can Call our Function.
        //Then get the first and second array Numbers.
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{questionIndex++}. What is {firstNumber} / {secondNumber} ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine($"Welldone {userName} Your Answer was Correct!");
            //If an Answer is Correct then we can add a point to our total. 
            score++;
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
            Console.WriteLine();

        }

        //We do Four as Iterators start from 0 instead of one, this means the Custom Amount of Iterations (0,1,2,3,4) would have passed.
        if (i == (totalScore - 1))
        {
            Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        }
    }
}
void MultiplicationGame()
{
    Console.WriteLine("Multiplication Selected");

    //Using the 'Random' Class, We can Take an Integer and Make it Random.
    var randomNum = new Random();
    int firstNum;
    int secondNum;

    int totalScore;
    Console.WriteLine("How Many Questions would you like? (Type it out in Integers)");
    totalScore = int.Parse(Console.ReadLine());
    int score = 0;
    int questionIndex = 1;

    //Using Console.Clear() As to Make the Screen Less Messy.
    Console.Clear();

    //Using a For Loop, We can make it so the Game Continues for 5 Questions instead of 1 Question.
    //We are using a Total Score Variable as it can Allow our Game to be Scalable.
    for (int i = 0; i < totalScore; i++)
    {
        firstNum = randomNum.Next(1, 20);
        secondNum = randomNum.Next(1, 20);

        Console.WriteLine($"{questionIndex++}. What is {firstNum} * {secondNum} ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum * secondNum)
        {
            Console.WriteLine($"Welldone {userName} Your Answer was Correct!");
            //If an Answer is Correct then we can add a point to our total. 
            score++;
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine($"Sorry {userName} Your Answer Was Incorrect!");
            Console.WriteLine();

        }

        //We do Four as Iterators start from 0 instead of one, this means the Custom Amount of Iterations (0,1,2,3,4) would have passed.
        if (i == (totalScore - 1))
        {
            Console.WriteLine($"Game Over {userName}!! Your Final Score is {score} out of {totalScore}");
        }
    }
}

//Creating an Array
//When using an Array, the function must always return something. 
int[] GetDivisionNumbers()
{
    var random = new Random();
    int firstNum = random.Next(1, 99);
    int secondNum = random.Next(1, 99);

    var result = new int[2];
    //The First Number of the Array is the First Number Variable.
    //Arrays also use 0 Indexs (0,1,2,3 etc)
    //The Use of [] is to Put that Data in Position of the Array.
    result[0] = firstNum;
    result[1] = secondNum;

    //For Each Number in the Result Collection.
    //For Each loops depend on the Preexising Amount within a Collection.
    //Whereas For Loops we have to Manually Set how many times we want it to loop.
    /* foreach (var number in result)
     {
         Console.WriteLine($"Array Element = {number}");
     }*/

    //A While Loop is A Loop that Keeps going Until a Condition is Satisified.
    //In this While Loop, we Will be Comparing the First and Second Numbers until they Create a Whole Number.
    //As With a Division Game, it is Very Easy to Create Numbers that are Floats (Decimals)
    //However to We Must Avoid that to Create an Easy to Use Game. 
    while (firstNum % secondNum != 0)
    {
        //Changing the Parameters of the Random to (1,99) as to Avoid getting 0.
        firstNum = random.Next(1, 99);
        secondNum = random.Next(1, 99);
    }

    //Now that two Numbers that can Be Divided into Whole Numbers are there.
    //We can now put those new numbers into the array and return that result to the main game function.
    result[0] = firstNum;
    result[1] = secondNum;

    return result;
}
