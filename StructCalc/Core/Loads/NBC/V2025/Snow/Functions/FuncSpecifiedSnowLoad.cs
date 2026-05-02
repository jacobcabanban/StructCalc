namespace StructCalc.Core.Loads.NBC.V2025.Snow.Functions;

internal static class FuncSpecifiedSnowLoad
{
    
/// <summary> Calculates specified roof snow load. </summary>
    /// <param name="Is"> Importance factor for snow load. </param>
    /// <param name="Ss"> 1-in-50 year ground snow load (kPa). </param>
    /// <param name="Cb"> Basic roof snow load factor. </param>
    /// <param name="Cw"> Wind exposure factor. </param>
    /// <param name="Cs"> Roof slope factor. </param>
    /// <param name="Ca"> Accumulation factor. </param>
    /// <param name="CT"> Thermal factor. </param>
    /// <param name="Sr"> Associated rain load (kPa). </param>
    /// <returns> Specified roof snow load (kPa). </returns>
    internal static double Equation(double Is, 
        double Ss, 
        double Cb, 
        double Cw, 
        double Cs, 
        double Ca, 
        double CT, 
        double Sr) 
    {
        return Is * (Ss * (Cb * Cw * Cs * Ca * CT) + Sr);
    }
}

