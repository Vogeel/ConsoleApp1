using System;

namespace Igual_ou_diferente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o primeiro numero");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");

            int n2 = int.Parse(Console.ReadLine());

            if (n2 == n1
                )
            {
                int resultado1 = n2 + n1;
                Console.WriteLine($"Os números são igual, entao:{n1} + {n2} = {resultado1}");
            }


            

            else
            {
                int resultado2 = n2 * n1;
                Console.WriteLine($"Os números são diferentes, entao:{n1} * {n2} = {resultado2}");
            }

            Console.ReadLine();
            
                   



        }
    }
}
