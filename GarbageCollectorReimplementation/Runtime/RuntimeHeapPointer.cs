namespace GarbageCollectorReimplementation;

/// <summary>
/// Pointer, to manage which cells are occupied or can be reclaimed.
/// </summary>
public class RuntimeHeapPointer
{
    public int Begin { get; set; }

    public int RequiredSize { get; set; }
}