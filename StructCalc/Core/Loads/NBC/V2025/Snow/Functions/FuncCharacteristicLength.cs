namespace StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

internal static class FuncCharacteristicLength
{
    /// <summary> Calculates characteristic length of roof. </summary>
    /// <param name="w"> Lesser plan dimension of roof (m). </param>
    /// <param name="l"> Greater plan dimension of roof (m). </param>
    /// <returns> Characteristic length, lc (m). </returns>
    internal static double Equation(double w, double l)
    {
        double min = Math.Min(w, l);
        double max = Math.Max(w, l);

        return 2.0 * min - (min * min) / max;
    }
}
