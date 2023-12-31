﻿using CSharpOO.Entities;
using System.Globalization;

//Exercício 01
#region Exercício 01
//Pessoa pessoa1 = new Pessoa();
//Pessoa pessoa2 = new Pessoa();

//Console.WriteLine("Dados da primeira pessoa:");
//Console.Write("Nome: ");
//pessoa1.Nome = Console.ReadLine();
//Console.Write("Idade: ");
//pessoa1.Idade = int.Parse(Console.ReadLine());

//Console.WriteLine("Dados da segunda pessoa:");
//Console.Write("Nome: ");
//pessoa2.Nome = Console.ReadLine();
//Console.Write("Idade: ");
//pessoa2.Idade = int.Parse(Console.ReadLine());

//Pessoa pessoaMaisVelha = pessoa1.Idade > pessoa2.Idade ? pessoa1 : pessoa2;
//Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha.Nome}");
#endregion

//Exercício 02
#region Exercício 02
Funcionario funcionario1 = new Funcionario();
Funcionario funcionario2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.Write("Nome: ");
funcionario1.Nome = Console.ReadLine();
Console.Write("Salário: ");
funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.Write("Nome: ");
funcionario2.Nome = Console.ReadLine();
Console.Write("Salário: ");
funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;
Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
#endregion