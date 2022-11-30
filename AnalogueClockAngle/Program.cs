using Calculators;

Console.WriteLine("Welcome to Analogue Clock Angle calculator!!");
Console.WriteLine("For hours use '01 -> 12' for minutes '00 -> 59'");
while (true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please input your time, format = >'HH:mm'. To exit enter 'exit'");
    Console.WriteLine("e.g. > 03:11");
    Console.WriteLine("e.g. > 12:44");
    Console.ResetColor();
    var userInput = Convert.ToString(Console.ReadLine());
                
    if (userInput == "exit")
    {
        break;
    }
    
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Your ange is {LesserAngleCalculator.GetAnalogueClockAngle(userInput)}");
    Console.ResetColor();
}