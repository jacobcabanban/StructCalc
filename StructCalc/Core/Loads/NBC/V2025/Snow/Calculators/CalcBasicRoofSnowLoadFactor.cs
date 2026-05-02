using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;
using StructCalc.Core.Models;

namespace StructCalc.Core.Loads.NBC.V2025.Snow.Calculators;

internal class CalcBasicRoofSnowLoadFactor
{
    internal static CalcResponse Calculate(
        double lc,
        double Ss,
        double gamma,
        double meanRoofHeightAboveGround
        )
    {
        double value = FuncBasicRoofSnowLoadFactor.Equation(lc, Ss, gamma, meanRoofHeightAboveGround);

        return new CalcResponse
        {
            Result = new()
            {
                Value = value,
                FormulaLatex = @"C_b = 1 - (0.2)\exp\left(-\frac{l_c - 70}{100}\right) \text{ for } l_c > 70",
                RecommendedDecimals = 3
            },

            Metadata = new()
            {
                MetaData = MetaDataNBC25.Snow.BasicRoofSnowLoadFactor
            },

            Inputs = new List<CalcInput>
            {
                new CalcInput {MetaData = MetaDataNBC25.Snow.CharacteristicLength},
                new CalcInput {MetaData = MetaDataNBC25.Snow.GroundSnowLoad},
                new CalcInput {MetaData = MetaDataNBC25.Snow.SpecificWeightOfSnow},
                new CalcInput {MetaData = MetaDataNBC25.Snow.MeanRoofHeight}
            }
        };
    }
}
