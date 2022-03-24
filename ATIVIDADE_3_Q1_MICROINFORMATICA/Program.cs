using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_Q1_MICROINFORMATICA
{         // •1 – Desenvolva um programa para calcular a área, diâmetro e perímetro do círculo.
             //•A = π . r²
            // •d=2 . r
            // •P = 2 . π.r
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double area;
            double PI = 3.14;


            Console.Write("Entre com o Raio do círculo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = raio * raio * PI;
            Console.WriteLine("A área do circulo é: " + area + "m²");

            double d = 2 * raio;
            Console.WriteLine("O diâmetro do círculo é: " + d);

            double p = 2 * PI * raio;
            Console.WriteLine("O perímetro do círculo é: " + p);

            Console.ReadKey();
        }
    }
}
