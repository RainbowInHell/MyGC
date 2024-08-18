namespace GarbageCollectorReimplementation;

/// <summary>
/// A reference to an address in the heap.
/// </summary>
public class RuntimeStackItem(int startIndexInTheHeap)
{
    public int StartIndexInTheHeap { get; } = startIndexInTheHeap;
}