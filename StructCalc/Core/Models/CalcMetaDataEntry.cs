
namespace StructCalc.Core.Models;

internal sealed class CalcMetaDataEntry
{
    internal required string Label { get; init; }
    internal required string Clause { get; init; }
    internal required string Symbol { get; init; }
    internal required string Unit { get; init; }
    internal required string Description { get; init; }
}
