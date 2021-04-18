using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11 {
    class Program {
        static void Main(string[] args) {

            //Dado um número qualquer, verifique se ele é primo;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= (x ^ 2); i++) {
                if (x % i == 1) {
                    Console.WriteLine($"O número {x} é primo.");
                    break;
                } else {
                    Console.WriteLine($"O número {x} não é primo.");
                    break;
                }

            }

        }
    }
}



