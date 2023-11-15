using ConsoleAppEx06;

Console.Write("Quantos quartos serão alugados? ");
int qtdQuartosQueSeraoAlugados = int.Parse(Console.ReadLine());
Quarto[] quartos = new Quarto[10];

Console.WriteLine();

for (int i = 1; i <= qtdQuartosQueSeraoAlugados; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int numeroQuarto = int.Parse(Console.ReadLine());

    quartos[numeroQuarto] = new Quarto { Estudante = new Estudante(nome, email), NumeroQuarto = numeroQuarto };
}
Console.WriteLine();

Console.WriteLine("Quartos Ocupados");
for (int i = 0; i < quartos.Length; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine($"{quartos[i].NumeroQuarto}: {quartos[i].Estudante.Nome}, {quartos[i].Estudante.Email}");
    }
}