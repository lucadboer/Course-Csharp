using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			char resp;
			double valor;
			Conta pessoa;

			Console.Write("Digite o número da conta: ");
			int numero = int.Parse(Console.ReadLine());

			Console.Write("Entre com o titular da conta: ");
			string nome = Console.ReadLine();

			Console.Write("Haverá depósito inicial (s/n)? ");
			resp = char.Parse(Console.ReadLine());
			if (resp == 's' || resp == 'S')
            {
				Console.Write("Entre o valor de depósito inicial: ");
				valor = double.Parse(Console.ReadLine());
				pessoa = new Conta(numero, nome, valor);

            }
            else{
				pessoa = new Conta(numero, nome);
            }

			Console.WriteLine($"\nDados da conta: \n{pessoa}");

			Console.Write("\nEntre um valor para depósito: ");
			double quantia = double.Parse(Console.ReadLine());
			pessoa.Deposito(quantia);
			Console.WriteLine($"Dados da conta: \n{pessoa}");

			Console.Write("\nEntre um valor para saque: ");
			quantia = double.Parse(Console.ReadLine());
			pessoa.Saque(quantia);
			Console.WriteLine($"Dados da conta: \n{pessoa}");


		}
	}
}
