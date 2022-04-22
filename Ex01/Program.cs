using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:\n");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            A.Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:\n");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            B.Idade = double.Parse(Console.ReadLine());

            if (A.Idade > B.Idade)
            {
                Console.WriteLine($"\nPessoa mais velha: {A.Nome}");
            }
            else
            {
                Console.WriteLine($"\nPessoa mais velha: {B.Nome}");
            }

            Console.WriteLine($"Média das idades: {((A.Idade + B.Idade) / 2).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}