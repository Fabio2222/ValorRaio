using System;

namespace Valor_Raio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi=3.1416, raio;

            Console.WriteLine("Escreva o raio");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("A area do circulo e {0}", (pi*raio*raio));
            

            
            Console.ReadLine();
        }
    }
}
