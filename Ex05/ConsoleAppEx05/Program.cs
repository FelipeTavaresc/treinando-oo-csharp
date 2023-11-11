using ConsoleAppEx05;
using System.Globalization;

Console.Write("Entre o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char op = char.Parse(Console.ReadLine());

Conta conta;
if (op == 's')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Conta(numeroConta, nomeTitular, saldoInicial);
}
else
{
    conta = new Conta(numeroConta, nomeTitular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(valorDeposito);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(valorSaque);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);



