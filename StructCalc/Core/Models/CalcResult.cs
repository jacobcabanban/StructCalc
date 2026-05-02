namespace StructCalc.Core.Models;

/// <summary>
/// Represents the numerical result of a structural calculation.
/// </summary>
internal sealed class CalcResult
{
    internal required double? Value { get; init; }   
    internal required string? FormulaLatex { get; init; }
    internal required int? RecommendedDecimals { get; init; }

}

