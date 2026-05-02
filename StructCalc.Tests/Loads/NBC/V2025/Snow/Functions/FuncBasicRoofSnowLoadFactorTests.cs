using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

namespace StructCalc.Tests.Loads.NBC.V2025.Snow.Functions;

public class FuncBasicRoofSnowLoadFactorTests
{
    [Fact]
    // Condition 1: Mean roof height greater than limit, lc < 70
    public void Equation_ReturnsCorrectValue_lcLessThan70_MeanRoofHeightGreaterThanLimit()
    {
        // Arrange  
        double lc = 57.14, Ss = 2.0, gamma = 3.4, meanRoofHeightAboveGrade = 2;

        // Act
        double result = FuncBasicRoofSnowLoadFactor.Equation(lc, Ss, gamma, meanRoofHeightAboveGrade);

        // Assert
        Assert.Equal(0.8, result, precision: 4);
    }

    [Fact]
    // Condition 2: Mean roof height greater than limit, lc > 70
    public void Equation_ReturnsCorrectValue_lcGreaterThan70_MeanRoofHeightGreaterThanLimit()
    {
        // Arrange  
        double lc = 165.9, Ss = 2.0, gamma = 3.4, meanRoofHeightAboveGrade = 2;

        // Act
        double result = FuncBasicRoofSnowLoadFactor.Equation(lc, Ss, gamma, meanRoofHeightAboveGrade);

        // Assert
        Assert.Equal(0.9233, result, precision: 4);
    }

    [Fact]
    // Condition 3: Mean roof height less than limit, lc < 70
    public void Equation_ReturnsCorrectValue_lcLessThan70_MeanRoofHeightLessThanLimit()
    {
        // Arrange  
        double lc = 57.14, Ss = 2.0, gamma = 3.4, meanRoofHeightAboveGrade = 1;

        // Act
        double result = FuncBasicRoofSnowLoadFactor.Equation(lc, Ss, gamma, meanRoofHeightAboveGrade);

        // Assert
        Assert.Equal(1.0, result, precision: 2);
    }

    [Fact]
    // Condition 4: Mean roof height less than limit, lc > 70
    public void Equation_ReturnsCorrectValue_lcGreaterThan70_MeanRoofHeightLessThanLimit()
    {
        // Arrange  
        double lc = 165.9, Ss = 2.0, gamma = 3.4, meanRoofHeightAboveGrade = 1;

        // Act
        double result = FuncBasicRoofSnowLoadFactor.Equation(lc, Ss, gamma, meanRoofHeightAboveGrade);

        // Assert
        Assert.Equal(1.0, result, precision: 2);
    }

}
