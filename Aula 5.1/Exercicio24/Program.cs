using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24 {
    class Program {
        static void Main(string[] args) {
            //Receba um valor qualquer de temperatura na escala Celsius e o converta para Farenheit
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            double fahrennheit = x * 1.8 + 32;

            Console.WriteLine($"{x}°C == {fahrennheit}°F");
        }
    }
}
