using StructCalc.Core.Models;

namespace StructCalc.Core.Loads.NBC.V2025
{
    internal class MetaDataNBC25
    {
        internal sealed class Snow
        {
            internal static readonly CalcMetaDataEntry AccumulationFactor = new()
            {
                Label = "Accumulation Factor",
                Clause = "Cl. 4.1.6.2.(8)",
                Symbol = @"C_a",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry BasicRoofSnowLoadFactor = new()
            {
                Label = "Basic Roof Snow Load Factor",
                Clause = "Cl. 4.1.6.2.(2)",
                Symbol = @"C_b",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry CharacteristicLength = new()
            {
                Label = "Characteristic Length",
                Clause = "Cl. 4.1.6.2.(2).(b)",
                Symbol = @"l_c",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry CharacteristicLengthMinimumDimension = new()
            {
                Label = "Smaller Plan Dimension of Roof",
                Clause = "Cl. 4.1.6.2.(2).(b)",
                Symbol = @"w",
                Unit = Unit.Length.Meter,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry CharacteristicLengthMaximumDimension = new()
            {
                Label = "Larger Plan Dimension of Roof",
                Clause = "Cl. 4.1.6.2.(2).(b)",
                Symbol = @"l",
                Unit = Unit.Length.Meter,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry GroundSnowLoad = new()
            {
                Label = "Ground Snow Load",
                Clause = "Subsection 1.1.3 and Appendix C",
                Symbol = @"S_s",
                Unit = Unit.Pressure.KiloPascal,
                Description = ""
            };       

            internal static readonly CalcMetaDataEntry ImportanceFactor = new()
            {
                Label = "Importance Factor",
                Clause = "Table 4.1.6.2",
                Symbol = @"I_s",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry MeanRoofHeight = new()
            {
                Label = "Mean Roof Height",
                Clause = "",
                Symbol = @"h",
                Unit= Unit.Length.Meter,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry RainLoad = new()
            {
                Label = "Rain Load",
                Clause = "Subsection 1.1.3 and Appendix C",
                Symbol = @"S_r",
                Unit = Unit.Pressure.KiloPascal,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry SlopeFactor = new()
            {
                Label = "Slope Factor",
                Clause = "Cl. 4.1.6.2.(5) to (7)",
                Symbol = @"C_s",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry SpecifiedSnowLoad = new()
            {
                Label = "Specified Snow Load",
                Clause = "Cl. 4.1.6.2.(1)",
                Symbol = @"S",
                Unit = Unit.Pressure.KiloPascal,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry SpecificWeightOfSnow = new()
            {
                Label = "Specific Weight of Snow",
                Clause = "Article 4.1.6.13",
                Symbol = @"\gamma_s",
                Unit = Unit.UnitWeight.KiloNewtonPerCubicMeter,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry ThermalFactor = new()
            {
                Label = "Thermal Factor",
                Clause = "Cl. 4.1.6.2.(10) & (11)",
                Symbol = @"C_T",
                Unit = Unit.UnitLess,
                Description = ""
            };

            internal static readonly CalcMetaDataEntry WindExposureFactor = new()
            {
                Label = "Wind Exposure Factor",
                Clause = "Cl. 4.1.6.2.(3) & (4)",
                Symbol = @"C_w",
                Unit = Unit.UnitLess,
                Description = ""
            };
        }
    }
}
