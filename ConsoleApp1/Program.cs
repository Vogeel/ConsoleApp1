using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crescente");
            int[] numeros =new int[3];

            Console.WriteLine("Digite o primeiro numero");

            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");

            numeros[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero");

            numeros[2] = int.Parse(Console.ReadLine());

            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int numero in numeros)
            {
                Console.Write(numero + "/");
            }

            Console.ReadKey();


        }
    }
}
