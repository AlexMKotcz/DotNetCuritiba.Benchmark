using BenchmarkDotNet.Attributes;

using System.Text;

[MemoryDiagnoser]
[RankColumn]
public class MemoriaBenchmarkString
{
	[Params(1000, 10000)]
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
