using System.Text.RegularExpressions;

namespace AnalogueClockAngle;

public class UserInputHandling
{
    public static string IsUserInputCorrect(string userInput)
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
            result = "Your entered format is wrong enter 2 digits ':' and another 2 digits!";
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
}