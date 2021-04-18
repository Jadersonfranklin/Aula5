using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10 {
    class Program {
        static void Main(string[] args) {

            //Dado um número qualquer, verifique se ele é par;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0) {
                Console.WriteLine();
                Console.WriteLine($"O número {x} é par.");
            }else {
                Console.WriteLine();
                Console.WriteLine($"O número {x} é impar.");
            }
        }
    }
}
