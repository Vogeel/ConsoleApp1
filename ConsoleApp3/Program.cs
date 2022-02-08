using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[2];

            Console.WriteLine("Qual seu peso?");

            numeros[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura?");

            numeros[1] = double.Parse(Console.ReadLine());

            double n1 = numeros[1] * numeros[1];

            double resultado = numeros[0] / n1;

            if (resultado < 18.5
                
                )
                Console.WriteLine("Você está abaixo do peso ideal");

            if( 25 >= resultado && resultado >= 18.5
                )
                Console.WriteLine("Você está em seu peso ideal");

            if (resultado > 25 && resultado <= 30
                )
                Console.WriteLine("Você está acima do peso");

            if (resultado > 30
                )
                Console.WriteLine("Você está obeso");

            Console.ReadLine();
                    
        }
    }
}
