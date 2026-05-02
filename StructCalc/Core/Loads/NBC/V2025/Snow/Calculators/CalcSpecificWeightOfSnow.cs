using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;
using StructCalc.Core.Models;

namespace StructCalc.Core.Loads.NBC.V2025.Snow.Calculators;

internal class CalcSpecificWeightOfSnow
{
    internal static CalcResponse Calculate(double Ss)
    {
        double value = FuncSpecificWeightOfSnow.Equation(Ss);

        return new CalcResponse
        {
            Result = new()
            {
                Value = value,
                FormulaLatex = @"\gamma = \min\left(4.0 \ \text{kN/m}^3, \ 0.43S_s + 2.2 \ \text{kN/m}^3\right)",
                RecommendedDecimals = 2
            },

            Metadata = new()
            {
                MetaData = MetaDataNBC25.Snow.SpecificWeightOfSnow
            },

            Inputs = new List<CalcInput>
            {
                new CalcInput {MetaData = MetaDataNBC25.Snow.GroundSnowLoad}
            }
        };

    }

}
