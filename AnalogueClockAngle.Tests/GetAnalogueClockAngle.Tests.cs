using Calculators;
using FluentAssertions;

namespace AnalogueClockAngle.Tests;

[TestClass]
public class GetAnalogueClockAngle_Tests
{
    [TestMethod]
    public void GetAnalogueClockAngle_11_59_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("11:59");
        // Assert
        result.Should().Be(5.5);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_12_05_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("12:05");
        // Assert
        result.Should().Be(27.5);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_11_50_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("11:50");
        // Assert
        result.Should().Be(55);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_03_45_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("03:45");
        // Assert
        result.Should().Be(157.5);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_12_00_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("12:00");
        // Assert
        result.Should().Be(0);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_06_30_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("06:30");
        // Assert
        result.Should().Be(15);
    }
    
    [TestMethod]
    public void GetAnalogueClockAngle_11_27_ShouldCalculateCorrectly()
    {
        // Act
        var result = LesserAngleCalculator.GetAnalogueClockAngle("11:27");
        // Assert
        result.Should().Be(178.5);
    }
    
    [TestMethod]
    public void IsUserInputCorrect_InputToLong_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("******!!!");
        // Assert
        result.Should().Be($"You entered something to much max input length is 5!\nYour input lenght is 9");
    }
    
    [TestMethod]
    public void IsUserInputCorrect_InputToShort_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("1");
        // Assert
        result.Should().Be("Something is missing your input lenght is not 5, but 1");
    }
    
    [TestMethod]
    public void IsUserInputCorrect_ColonIsNotThere_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("12*12");
        // Assert
        result.Should().Be("You forgot to add ':' between numbers");
    }
    
    [TestMethod]
    public void IsUserInputCorrect_DigitsAreNotEntered_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("**:12");
        // Assert
        result.Should().Be("Your entered format is wrong enter 2 digits ':' and another 2 digits!");
    }
    
    [TestMethod]
    public void IsUserInputCorrect_HourToBigOrSmall_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("99:12");
        // Assert
        result.Should().Be("Your entered hour to big or to small pleases check your input again!");
    }
    
    [TestMethod]
    public void IsUserInputCorrect_MinuteToBigOrSmall_ShouldReturnCorrectString()
    {
        // Act
        var result = UserInputHandling.IsUserInputCorrect("11:99");
        // Assert
        result.Should().Be("Your entered minute to big or to small pleases check your input again!");
    }
}