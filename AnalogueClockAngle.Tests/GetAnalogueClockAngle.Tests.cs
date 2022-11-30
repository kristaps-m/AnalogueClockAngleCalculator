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
}