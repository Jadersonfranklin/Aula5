using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20 {
    class Program {
        static void Main(string[] args) {

            /*Receba do usuário um valor inteiro r qualquer e calcule o perímetro da circunferência,
            a área do círculo e o volume da esfera que tenham esse raio;*/
            double pi = 3.14;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            int raio = x / 2;
            double pCircunferencia = (2 * pi) * raio;
            double aCirculo = pi * Math.Pow(raio, 2);
            double vEsfera = (4 * pi) * (Math.Pow(raio, 3) / 3);

            Console.WriteLine($"O Perímetro da circunferência do raio é: {pCircunferencia}");
            Console.WriteLine($"A Área do círculo é: {aCirculo}");
            Console.WriteLine($"O Volume da esfera é: {vEsfera}");

        }
    }
}
