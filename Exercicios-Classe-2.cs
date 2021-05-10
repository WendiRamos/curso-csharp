using System;
using System.Globalization;

namespace Exercicio_Classe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Entre os dados do primeiro funcionario.");
            Console.WriteLine("Nome:");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f1.salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre os dados do segundo funcionario.");
            Console.WriteLine("Nome:");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f2.salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media;
            media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
