using System;
using System.Globalization;

namespace classe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retângulo ret = new Retângulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    /* class Retângulo
     {
         public double Largura;
         public double Altura;

         public double Area()
         {
             return Largura * Altura;
         }
         public double Perimetro()
         {
             return 2 * (Largura + Altura);
         }
         public double Diagonal()
         {
             return Math.Sqrt(Largura * Altura * Altura);
         }
     }*/
}
