using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= (x ^ 2); i++) {
                if(x % i == 1) {
                    Console.WriteLine("O número {0:d} é primo.",i);
                }
            }
        }
    }
}
