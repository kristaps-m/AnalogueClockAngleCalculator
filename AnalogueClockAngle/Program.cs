using System.Text.RegularExpressions;
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
    else if (IsUserInputCorrect(userInput) != userInput)
    {
        Console.WriteLine(IsUserInputCorrect(userInput));
        var getCorrectInput = "";
        
        while (IsUserInputCorrect(getCorrectInput) != getCorrectInput)
        {
            getCorrectInput = Console.ReadLine();
            if (getCorrectInput == "exit")
            {
                userInput = getCorrectInput;
                Console.WriteLine("Good bye!");
                break;
            }
            Console.WriteLine(IsUserInputCorrect(getCorrectInput));
            Console.WriteLine("Please input correct time! 'HH:mm'");
        }

        userInput = getCorrectInput;
    }
    
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Your ange is {LesserAngleCalculator.GetAnalogueClockAngle(userInput)}");
    Console.ResetColor();
}

string IsUserInputCorrect(string userInput)
{
    var result = "";
    var isInputCorrect = true;
    string pattern = @"\d\d:\d\d";
    
    if(userInput.Length > 5)
    {
        result = $"You entered something to much max input length is 5!\nYour input lenght is {userInput.Length}";
        isInputCorrect = false;
    }
    else if (userInput.Length < 5)
    {
        result = $"Something is missing your input lenght is not 5, but {userInput.Length}";
        isInputCorrect = false;
    }
    else if (!userInput.Contains(':'))
    {
        result = "You forgot to add ':' between numbers";
        isInputCorrect = false;
    }
    else if (!Regex.IsMatch(userInput, pattern, RegexOptions.IgnoreCase))
    {
        result = $"Your entered format is wrong enter 2 digits ':' and another 2 digits!";
        isInputCorrect = false;
    }
    else
    {
        var hour = Convert.ToInt16(userInput.Split(':')[0]);
        var minute = Convert.ToInt16(userInput.Split(':')[1]);
        if (hour < 1 || hour > 12)
        {
            result = "Your entered hour to big or to small pleases check your input again!";
            isInputCorrect = false;
        }
        else if (minute < 0 || minute > 59)
        {
            result = "Your entered minute to big or to small pleases check your input again!";
            isInputCorrect = false;
        }
    }

    return isInputCorrect ? userInput : result;
}