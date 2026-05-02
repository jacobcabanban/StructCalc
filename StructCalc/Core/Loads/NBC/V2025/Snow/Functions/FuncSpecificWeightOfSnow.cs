namespace StructCalc.Core.Loads.NBC.V2025.Snow.Functions;
internal class FuncSpecificWeightOfSnow
{
    /// <summary>
    /// Calculates the specific weight of snow (kN/m³) per NBC 2025, capped at 4.0 kN/m³.
    /// </summary>
    /// <param name="Ss">
    /// The 1-in-50-year ground snow load (kPa) for the building site,
    /// obtained from NBC 2025 Appendix C climatic data tables.
    /// </param>
    /// <returns>Specific weight of snow (kN/m³).</returns>
    internal static double Equation(double Ss) => Math.Min( 4, (0.43 * Ss + 2.20) );

}
