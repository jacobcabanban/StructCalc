namespace StructCalc.Core.Models;

internal sealed class CalcResponse
{
    internal required CalcResult Result { get; init; }
    internal required CalcMetaData Metadata { get; init; }
    internal CalcWarning? Warning { get; init; } 
    internal required IReadOnlyList<CalcInput> Inputs { get; init; }
    
}

