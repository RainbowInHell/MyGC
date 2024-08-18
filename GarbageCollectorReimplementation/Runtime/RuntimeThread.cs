namespace GarbageCollectorReimplementation;

/// <summary>
/// Smallest unit of execution within a process.
/// When a thread executes an instruction, it is placed on its stack,
/// and any potential reference to the heap is retained in an internal dictionary.
/// This mechanism ensures that each thread maintains its own stack while references
/// to the shared heap are tracked to manage memory allocation and deallocation effectively.
/// </summary>
public class RuntimeThread(int stackSize, string name)
{
    private readonly Stack<RuntimeStackItem> _stack = new(stackSize);
    private int _index = 0;

    public string Name { get; set; } = name;

    public Dictionary<int, RuntimeStackItem> Roots { get; } = new();

    public void PushInstruction(string value)
    {
        _index++;

        if (_index > stackSize)
        {
            throw new StackOverflowException();
        }

        var address = GarbageCollector.Allocate(value); 
        var stackItem = new RuntimeStackItem(address);

        _stack.Push(stackItem);
        Roots.Add(address, stackItem);
    }

    public void PopInstruction()
    {
        _index--;

        var item = _stack.Pop();
        Roots.Remove(item.StartIndexInTheHeap);
    }
}