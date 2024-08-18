namespace GarbageCollectorReimplementation;

/// <summary>
/// An instruction to be handled by the <see cref="Runtime"/>.
/// </summary>
public class Instruction(string affectedThread, string operation, string? value = null)
{
    /// <summary>
    /// Which thread is affected by the instruction.
    /// </summary>
    public string AffectedThread { get; } = affectedThread;

    /// <summary>
    /// The operation to be performed.
    /// </summary>
    public string Operation { get; } = operation;

    /// <summary>
    /// A value to complement the operation.
    /// </summary>
    public string? Value { get; } = value;
}