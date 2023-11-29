using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using System.Text;

[MemoryDiagnoser]
//[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net80)]
[RankColumn]
public class MemoriaBenchmarkString
{
	[Params(10000)]
	public int numero_de_itens;
	[Benchmark]
	public string ConcatenandoStringsCom_StringBuilder()
	{
		StringBuilder sb = new();
		for (int i = 0; i < numero_de_itens; i++)
		{
			sb.Append("Alex Mariano " + i);
		}
		return sb.ToString();
	}
	[Benchmark]
	public string ConcatStringsUsando_GenericList()
	{
		List<string> list = new(numero_de_itens);
		for (int i = 0; i < numero_de_itens; i++)
		{
			list.Add("Alex Mariano" + i);
		}
		return list.ToString();
	}
}
