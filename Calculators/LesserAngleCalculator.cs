namespace Calculators;

public class LesserAngleCalculator
{
    private const int EVERY_MINUTE_LONG_HAND_MOVES = 6;
    private const int HOUR_HAND_MOVES_EACH_HOUR = 30;
    private const double HOUR_HAND_MOVES_EACH_MIN = 0.5;
        
    public static double GetAnalogueClockAngle(string time)
    {
        var hours = Convert.ToInt32(time.Split(':')[0]);
        var minutes = Convert.ToInt32(time.Split(':')[1]);
        var minuteAngle = minutes * EVERY_MINUTE_LONG_HAND_MOVES;
        var hourAngle = HOUR_HAND_MOVES_EACH_HOUR * hours + HOUR_HAND_MOVES_EACH_MIN * minutes;
        var firstAngle = Math.Abs(hourAngle - minuteAngle);
        var theAngle = Math.Min(360 - firstAngle, firstAngle);

        return theAngle;
    }
}