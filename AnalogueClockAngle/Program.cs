using AnalogueClockAngle;
using Calculators;

Console.WriteLine("Welcome to Analogue Clock Angle calculator!!");
Console.WriteLine("For hours use '01 -> 12' for minutes '00 -> 59'");
var userInput = "";

while (userInput != "exit")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please input your time, format = >'HH:mm'. To exit enter 'exit'");
    Console.WriteLine("e.g. > 03:11");
    Console.WriteLine("e.g. > 12:44");
    Console.ResetColor();
    userInput = Console.ReadLine();
    
    if (userInput == "exit")
    {
        Console.WriteLine("Good bye!");
    }
    else if (UserInputHandling.IsUserInputCorrect(userInput) != userInput)
    {
        Console.WriteLine(UserInputHandling.IsUserInputCorrect(userInput));
        var getCorrectInput = "";
        
        while (UserInputHandling.IsUserInputCorrect(getCorrectInput) != getCorrectInput)
        {
            getCorrectInput = Console.ReadLine();
            if (getCorrectInput == "exit")
            {
                userInput = getCorrectInput;
                Console.WriteLine("Good bye!");
                break;
            }
            Console.WriteLine(UserInputHandling.IsUserInputCorrect(getCorrectInput));
            Console.WriteLine("Please input correct time! 'HH:mm'");
        }

        userInput = getCorrectInput;
    }
    
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Your ange is {LesserAngleCalculator.GetAnalogueClockAngle(userInput)}");
    Console.ResetColor();
}