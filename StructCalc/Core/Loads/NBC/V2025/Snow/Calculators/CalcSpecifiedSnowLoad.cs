using StructCalc.Core.Loads.NBC.V2025.Snow.Functions;
using StructCalc.Core.Models;

namespace StructCalc.Core.Loads.NBC.V2025.Snow.Calculators;

internal static class CalcSpecifiedSnowLoad
{
    internal static CalcResponse Calculate(
        double Is,
        double Ss,
        double Cb,
        double Cw,
        double Cs,
        double Ca,
        double CT,
        double Sr)      
    {
       double value = FuncSpecifiedSnowLoad.Equation(Is, Ss, Cb, Cw, Cs, Ca, CT, Sr);

        return new CalcResponse
        {
            Result = new()
            {
                Value = value,
                FormulaLatex = @"S = I_s \left[ S_s \left( C_b \cdot C_w \cdot C_s \cdot C_a \cdot C_T \right) + S_r \right]",
                RecommendedDecimals = 2
            },

            Metadata = new()
            {
                MetaData = MetaDataNBC25.Snow.SpecifiedSnowLoad
            },           

            Inputs = new List<CalcInput>
            {
                new CalcInput {MetaData = MetaDataNBC25.Snow.ImportanceFactor },
                new CalcInput {MetaData = MetaDataNBC25.Snow.GroundSnowLoad},
                new CalcInput {MetaData = MetaDataNBC25.Snow.BasicRoofSnowLoadFactor},
                new CalcInput {MetaData = MetaDataNBC25.Snow.WindExposureFactor},
                new CalcInput {MetaData = MetaDataNBC25.Snow.SlopeFactor},
                new CalcInput {MetaData = MetaDataNBC25.Snow.AccumulationFactor},
                new CalcInput {MetaData = MetaDataNBC25.Snow.ThermalFactor},
                new CalcInput {MetaData = MetaDataNBC25.Snow.RainLoad}
            }
        };
    }
}

