using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double resultado;

            Console.Write("Digite sua 1a nota aqui: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite sua 2a nota aqui: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite sua 3a nota aqui: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite sua 2a nota aqui: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado >= 6)
            {
                Console.WriteLine($"Parabéns, sua nota é {resultado}, está aprovado!");
            }
            if (resultado <= 4)
            {
                Console.WriteLine($"Olá, sua nota é {resultado}, você está reprovado");
            } 
            else
            {
                Console.WriteLine($"Sua nota é {resultado} e você está de recuperação");
            }
        }
    }
}
