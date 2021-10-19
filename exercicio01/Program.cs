using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            decimal nota01 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            decimal nota02 = Convert.ToDecimal(Console.ReadLine());

            decimal media = (nota01 + nota02) / 2;

            if (media == 10)
            {
                Console.WriteLine("Aprovado com distinção");
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
