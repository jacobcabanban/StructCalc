namespace StructCalc.Core.Models;

/// <summary>
/// Provides standardized unit abbreviations used throughout the application.
/// </summary>
internal static class Unit
{
    internal const string UnitLess = @"-";   
    internal static class Length
    {
        internal const string Millimeter = @"\text{mm}";
        internal const string Meter = @"\text{m}";
        internal const string Feet = @"\text{ft}";
        internal const string Inch = @"\text{in}";
    }

    internal static class Area
    {
        internal const string SquareMeter = @"\text{m}^2";
        internal const string SquareFeet = @"\text{ft}^2";
    }

    internal static class Volume
    {
        internal const string CubicMeter = @"\text{m}^3";
        internal const string CubicFeet = @"\text{ft}^3";
    }

    internal static class Pressure
    {
        internal const string KiloPascal = @"\text{kPa}";
        internal const string MegaPascal = @"\text{MPa}";
        internal const string PoundsPerSquareFoot = @"\text{psf}";
        internal const string KiloPoundsPerSquareFoot = @"\text{ksf}";
    }

    internal static class UnitWeight
    {
        internal const string KiloNewtonPerCubicMeter = @"\text{kN/m}^3";
    }

    internal static class Force
    {
        internal const string Newton = @"\text{N}";
        internal const string KiloNewton = @"\text{kN}";
        internal const string Pound = @"\text{lbf}";
        internal const string KiloPound = @"\text{kip}";
    }

    internal static class Moment
    {
        internal const string KiloNewtonMeter = @"\text{kN·m}";
        internal const string NewtonMeter = @"\text{N·m}";
        internal const string FootPound = @"\text{ft·lb}";
        internal const string InchPound = @"\text{in·lb}";
        internal const string KipFoot = @"\text{kip·ft}";
    }
}