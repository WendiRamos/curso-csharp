using System;
using System.Globalization;

namespace classe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Nome:");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto:");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto:");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();
            Console.WriteLine("Desej aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

        }
    }
    /* class Funcionario
     {
         public string Nome;
         public double SalarioBruto;
         public double Imposto;

         public double SalarioLiquido()
         {
             return SalarioBruto - Imposto;
         }
         public void AumentarSalario(double porcentagem)
         {
             SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
         }
         public override string ToString()
         {
             return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
         }
     }*/
}
