using System;
using System.Globalization;
using System.Collections.Generic;

namespace listas_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite a id do empregado que terá aumento salarial : ");
            int pesquisaId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == pesquisaId);
            if (emp != null)
            {
                Console.Write("Entre a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}