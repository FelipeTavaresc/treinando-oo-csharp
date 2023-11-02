using CSharpOO;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
pessoa1.Nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
pessoa2.Nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());

Pessoa pessoaMaisVelha = pessoa1.Idade > pessoa2.Idade ? pessoa1 : pessoa2;
Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha.Nome}");
