using System;

namespace while01{
    class Program{
        static void Main(string[] args){
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002){
                Console.Write("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
