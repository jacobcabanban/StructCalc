using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

namespace StructCalc.Tests.Loads.NBC.V2025.Snow.Functions;

public class FuncSpecifiedSnowLoadTests
{
    [Fact]
    public void Equation_ReturnsCorrectValue_ForTypicalInputs()
    {
        // Arrange
        double Is = 1.25, Ss = 1.8, Cb = 0.8, Cw = 1.0,
               Cs = 1.0, Ca = 1.0, CT = 1.0, Sr = 0.2;

        // Act
        double result = FuncSpecifiedSnowLoad.Equation(Is, Ss, Cb, Cw, Cs, Ca, CT, Sr);

        // Assert
        // S = 1.25 * (1.8 * (0.8 * 1.0 * 1.0 * 1.0 * 1.0) + 0.2) = 1.64
        Assert.Equal(2.05, result, precision: 2);
    }

}