namespace GarbageCollectorReimplementation;

/// <summary>
/// An execution engine (runtime) capable of handling instructions,
/// with a particular focus on memory allocation and deallocation.
/// </summary>
public class Runtime
{
    private List<Instruction> _instructions;

    public Runtime(List<Instruction> instructions, string collectorStrategy)
    {
        _instructions = instructions;
        GarbageCollector.SetCollectorStrategy(collectorStrategy);
    }

    public void Run()
    {
        foreach (var instruction in _instructions)
        {
            GarbageCollector.ExecuteInstruction(instruction);
            GarbageCollector.PrintMemory();
        }
    }
}