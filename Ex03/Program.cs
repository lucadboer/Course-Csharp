using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Aluno alu = new Aluno();

			Console.WriteLine("Digite o nome do aluno:");
			alu.Nome = Console.ReadLine();

			Console.WriteLine("\nDigite as três notas do aluno:");
			alu.Nota1 = double.Parse(Console.ReadLine());
			alu.Nota2 = double.Parse(Console.ReadLine());
			alu.Nota3 = double.Parse(Console.ReadLine());

			Console.WriteLine($"Nota final: {alu.NotaFinal()}");
			Console.WriteLine($"\nAluno: {alu.AproRepro()}");
			
			if (alu.NotaFinal() < 60)
            {
				Console.WriteLine($"Faltaram {alu.NotaRestante()} pontos");
            }


		}
	}
}