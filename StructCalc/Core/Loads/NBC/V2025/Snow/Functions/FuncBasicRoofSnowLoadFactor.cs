namespace StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

internal static class FuncBasicRoofSnowLoadFactor
{
    /// <summary> Calculates basic roof snow load factor. </summary>
    /// <param name="lc"> Characteristic length of roof (m). </param>
    /// <param name="Ss"> 1-in-50 year ground snow load (kPa). </param>
    /// <param name="gamma"> Unit weight of snow (kN/m³). </param>
    /// <param name="meanRoofHeightAboveGrade"> Mean roof height above grade (m). </param>
    /// <returns> Basic roof snow load factor, Cb. </returns>
    internal static double Equation(
        double lc,
        double Ss,
        double gamma,
        double meanRoofHeightAboveGrade)
    {
        // NBCC 2025 Cl. 4.1.6.2.(2)(b):
        // Cb = 1.0 for roofs with mean height < 1 + Ss/gamma above grade
        double lowRoofHeightLimit = 1.0 + (Ss / gamma);

        if (meanRoofHeightAboveGrade < lowRoofHeightLimit)
            return 1.0;

        // NBCC 2025 Cl. 4.1.6.2.(2)(a)
        if (lc <= 70.0)
            return 0.80;

        return 1.0 - 0.20 * Math.Exp(-(lc - 70.0) / 100.0);
    }
}
