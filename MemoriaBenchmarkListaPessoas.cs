using BenchmarkDotNet.Attributes;


public record Pessoa(string Nome, int Idade);

[MemoryDiagnoser]
[RankColumn]
public class MemoriaBenchmarkListaPessoas
{
	[Params(1000, 10000)]
	public int numero_de_itens;
	static Pessoa ObterPessoa() => new("Alex Mariano", 21);

	[Benchmark]
	public void Criar_10000_Com_Capacidade()
	{
		List<Pessoa> pessoas = new(numero_de_itens);

		for (int i = 0; i < numero_de_itens; i++)
		{
			pessoas.Add(ObterPessoa());
		}
	}

	[Benchmark]
	public void Criar_10000_Sem_Capacidade()
	{
		List<Pessoa> pessoas = [];

		for (int i = 0; i < numero_de_itens; i++)
		{
			pessoas.Add(ObterPessoa());
		}
	}
}