using BenchmarkDotNet.Running;

Console.WriteLine("### Usando BenchmarkDotNet  ###\n");

BenchmarkRunner.Run<MemoriaBenchmarkString>();
Console.Read();
BenchmarkRunner.Run<MemoriaBenchmarkListaPessoas>();
Console.Read();
