using ConsoleAppEx01;
using System.Globalization;

Console.WriteLine("Entre a largura e altura do retângulo:");

Retangulo retangulo = new Retangulo();
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"AREA {retangulo.Area().ToString("F2")}");
Console.WriteLine($"PERIMETRO {retangulo.Perimetro().ToString("F2")}");
Console.WriteLine($"DIAGONAL {retangulo.Diagonal().ToString("F2")}");