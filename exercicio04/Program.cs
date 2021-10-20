using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            decimal percentualReajuste = 0;

            if (salario < 2800)
                percentualReajuste = 0.2M;
            else if (salario >= 2800 && salario < 7000)
                percentualReajuste = 0.15M;
            else if (salario >= 7000 && salario < 15000)
                percentualReajuste = 0.1M;
            else
                percentualReajuste = 0.05M;

            decimal valorRealReajuste = salario * percentualReajuste;
            decimal novoSalario = salario + valorRealReajuste;

            Console.WriteLine($"Salário Base: R$ {string.Format("{0:0.00}", salario)}\nPercentual de aumento: {string.Format("{0:0.00}", percentualReajuste * 100)}%\nValor do aumento: R$ {string.Format("{0:0.00}", valorRealReajuste)}\nNovo Salário: R$ {string.Format("{0:0.00}", novoSalario)}");
        }
    }
}
