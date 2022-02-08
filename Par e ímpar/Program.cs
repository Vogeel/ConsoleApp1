using System;

namespace Par_e_ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

            int numero = int.Parse(Console.ReadLine());

            
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número Acime é Par");
            }
            
            else
            {
                Console.WriteLine("O número acime é ímpar");
            }
            
            Console.ReadLine();
        }
    }
}
