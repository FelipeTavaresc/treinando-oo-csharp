﻿using ConsoleAppEx02;
using System.Globalization;

Funcionario funcionario = new Funcionario();
Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + funcionario);

Console.Write("Digite a porcentagem para aumentar o salário: ");
funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine($"Dados atualizados: {funcionario}");
