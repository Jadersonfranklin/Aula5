using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25 {
    class Program {
        static void Main(string[] args) {
            //Receba um valor qualquer de temperatura na escala Farenheit e o converta para Celsius;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            double celsium = (x - 32) / 1.8;

            Console.WriteLine($"{x}°F == {celsium}°C");
        }
    }
}
