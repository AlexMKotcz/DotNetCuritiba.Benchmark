using BenchmarkDotNet.Running;

Console.WriteLine("### Usando BenchmarkDotNet  ###\n");

BenchmarkRunner.Run<MemoriaBenchmarkString>();
Console.Read();
