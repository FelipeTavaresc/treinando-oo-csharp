﻿using ConsoleAppEx03;
using System.Globalization;

Aluno aluno = new Aluno();
Console.Write("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2")}");
if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine($"FALTARAM {aluno.NotaFaltante().ToString("F2")} PONTOS");
}