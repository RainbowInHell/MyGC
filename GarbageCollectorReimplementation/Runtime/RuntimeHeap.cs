namespace GarbageCollectorReimplementation;

/// <summary>
/// A memory area, where each memory cell represents with a char class.
/// With this abstraction, a heap is nothing more than a list of cells that can be allocated.
/// It also includes additional plumbing code, such as pointers,
/// to manage which cells are occupied or can be reclaimed.
/// </summary>
public class RuntimeHeap
{
    public RuntimeHeap(int size)
    {
        Size = size;
        Cells = new RuntimeHeapCell[size];
        Pointers = new List<RuntimeHeapPointer>();

        for (var i = 0; i < size; i++)
        {
            Cells[i] = new RuntimeHeapCell();
        }
    }

    public int Size { get; set; }

    public RuntimeHeapCell[] Cells { get; set; }

    public List<RuntimeHeapPointer> Pointers { get; set; }
}