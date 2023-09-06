string nome, sobrenome;
Console.Write("Digite o seu nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite o seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálago: {sobrenome.ToUpper()}, {nome}");