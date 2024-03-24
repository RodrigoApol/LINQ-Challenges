// App de desafios em LINQ

#region Desafio 1: Filtrar uma lista de números
#endregion Use LINQ para encontrar todos os números pares na lista 

List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

var numeroPares = numeros
    .Where(e => e % 2 == 0)
    .ToArray();

foreach (var item in numeroPares)
{
    Console.WriteLine(item);
}

#region Desafio 2: Agrupar uma lista de palavras por tamanho
#endregion Use LINQ para agrupar as palavras pelo tamanho delas

List<string> palavras = ["C#", "LINQ", "desafio", "programação", "estudo"];

var palavrasPorTamanho = palavras
    .OrderBy(e => e.Length)
    .ToList();

foreach (var item in palavrasPorTamanho)
{
    Console.WriteLine(item);
}

#region Desafio 3: Ordenar uma lista de estudantes
#endregion Use LINQ para ordenar a lista de estudantes por idade

List<Estudante> estudantes = new List<Estudante>
{
    new Estudante { Nome = "João", Idade = 20 },
    new Estudante { Nome = "Maria", Idade = 22 },
    new Estudante { Nome = "Pedro", Idade = 21 }
};

var estudantesPorIdade = estudantes
    .OrderBy(e => e.Idade)
    .ToList();

foreach (var item in estudantesPorIdade)
{
    Console.WriteLine(item.Nome);
}

#region Desafio 4: Calcular a média de uma lista de números
#endregion Use LINQ para calcular a média dos números na lista

List<int> numeros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var media = (decimal)numeros2.Sum() / numeros2.Count;

Console.WriteLine(media);

class Estudante
{
    public string Nome { get; set; } = null!;
    public int Idade { get; set; }
}