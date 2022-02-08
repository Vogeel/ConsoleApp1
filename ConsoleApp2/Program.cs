using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            Console.WriteLine("Digite o primeiro numero(A)");

            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero(B)");

            numeros[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero(C)");

            numeros[2] = int.Parse(Console.ReadLine());

            if (numeros[0] + numeros[1] > numeros[2]
                )

                Console.WriteLine("A soma dos numeros A e B, são maiores que C");

            else Console.WriteLine("A soma dos numeros A e B NÃO são maiores que C");
          

            Console.ReadLine();

        }
    }
}
