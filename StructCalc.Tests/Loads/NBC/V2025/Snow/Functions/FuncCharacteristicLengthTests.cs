using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;


namespace StructCalc.Tests.Loads.NBC.V2025.Snow.Functions;

public class FuncCharacteristicLengthTests
{
    [Fact]
    public void Equation_ReturnsCorrectValue_ForTypicalInputs()
    {
        // Arrange
        double w = 40, l = 70;
      
        // Act       
        double result = FuncCharacteristicLength.Equation(w, l);

       
        // Assert        
        Assert.Equal(57.14, result, precision: 2);
    }

}

