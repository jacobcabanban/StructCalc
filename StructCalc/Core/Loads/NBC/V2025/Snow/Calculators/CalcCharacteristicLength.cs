using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;
using StructCalc.Core.Models;

namespace StructCalc.Core.Loads.NBC.V2025.Snow.Calculators;

internal class CalcCharacteristicLength
{
    internal static CalcResponse Calculate(double w, double l)
    {
        double value = FuncCharacteristicLength.Equation(w, l);

        return new CalcResponse
        {
            Result = new()
            {
                Value = value,
                FormulaLatex = "",
                RecommendedDecimals = 2
            },

            Metadata = new()
            {
                MetaData = MetaDataNBC25.Snow.CharacteristicLength
            },

            Inputs = new List<CalcInput>()
            {
                new CalcInput {MetaData = MetaDataNBC25.Snow.CharacteristicLengthMinimumDimension },
                new CalcInput {MetaData = MetaDataNBC25.Snow.CharacteristicLengthMaximumDimension }
            }
        };
    }
}
