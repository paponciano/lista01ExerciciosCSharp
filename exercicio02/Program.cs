using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int numero03 = Convert.ToInt32(Console.ReadLine());

            int maior = 0;

            if (numero01 > numero02)
            {
                maior = numero01;
            }
            else
            {
                maior = numero02;
            }

            if (numero03 > maior)
            {
                maior = numero03;
            }

            Console.WriteLine("O maior número é: " + maior);

            int menor = maior;

            if (numero01 < menor)
                menor = numero01;
            
            if (numero02 < menor)
                menor = numero02;

            if (numero03 < menor)
                menor = numero03;

            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
