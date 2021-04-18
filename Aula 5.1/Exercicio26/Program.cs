using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26 {
    class Program {
        static void Main(string[] args) {
            //Receba um número inteiro qualquer e imprima suas raízes quadrada e cúbica, seu quadrado e seu cubo.
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"A raiz quadrada de {x} é: " + Math.Sqrt(x));
            Console.WriteLine($"A raiz cúbica de {x} é: " + Math.Pow(x, (1 / 3)));
            Console.WriteLine($"O quadrado de {x} é: " + Math.Pow(x, 2));
            Console.WriteLine($"O cubo de {x} é: " + Math.Pow(x, 3));
        }
    }
}
