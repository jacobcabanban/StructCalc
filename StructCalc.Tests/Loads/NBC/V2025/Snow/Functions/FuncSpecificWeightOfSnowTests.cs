
using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

namespace StructCalc.Tests.Loads.NBC.V2025.Snow.Functions;

public class FuncSpecificWeightOfSnowTests
{
    [Fact]
    public void Equation_ReturnsCorrectValue_MinVal()
    {
        // Arrange
        double Ss = 3.0;

        // Act
        double result = FuncSpecificWeightOfSnow.Equation(Ss);

        // Assert
        Assert.Equal(3.49, result, precision: 2);
    }

    [Fact]
    public void Equation_ReturnsCorrectValue_MaxVal()
    {
        // Arrange
        double Ss = 4.5;

        // Act
        double result = FuncSpecificWeightOfSnow.Equation(Ss);

        // Assert
        Assert.Equal(4.00, result, precision: 2);
    }






}
