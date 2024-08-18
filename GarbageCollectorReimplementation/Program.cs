using GarbageCollectorReimplementation;

var instructions = new List<Instruction>();
await foreach(var line in File.ReadLinesAsync(Path.Combine(AppContext.BaseDirectory, "/instructions.txt")))
{
    var c = line.Split(';');
    var instruction = new Instruction(c[0], c[1], c[2]);
    
    instructions.Add(instruction);
}

var runtime = new Runtime(instructions, "MARK_AND_COMPACT");
runtime.Run();