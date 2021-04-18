using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12 {
    class Program {
        static void Main(string[] args) {

            int nPerfeito;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            nPerfeito = (2 ^ (x - 1)) * (2 ^ x - 1);

            if(nPerfeito == x) {
                Console.WriteLine($"O número {x} é perfeito!");
            } else {
                Console.WriteLine($"O número {x} não é perfeito");
            }

        }
    }
}
