using ConsoleAppEx04;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar ? ");
double quatidadeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoedas.CotacaoEmReais(cotacao, quatidadeDolares).ToString("F2")}");