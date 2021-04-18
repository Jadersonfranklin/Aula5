using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7 {
    class Program {
        static void Main(string[] args) {

            //Dado um número qualquer, ache todos os seus divisores;
            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x / 2; i++) {
                if (x % i == 0) 
                    Console.Write("{0} ", i);
            }

            Console.WriteLine(x);


        }
    }
}
