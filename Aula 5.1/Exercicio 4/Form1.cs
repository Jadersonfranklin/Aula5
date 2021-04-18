using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Receba três valores double que são as medidas dos lados de um triângulo. Apresente na tela mensagens:  
        //1- Não é um triângulo(a soma de dois lados é menor que o outro ou se algum lado é menor ou igual a zero);
        //2- É um triângulo equilátero(três lados iguais);
        //3- É um triângulo escaleno(três lados diferentes);
        //4- É um triângulo isósceles(dois lados iguais e um diferente)
        private void buttonIgual_Click(object sender, EventArgs e) {
            double num1 = Convert.ToDouble(Numero1.Text);
            double num2 = Convert.ToDouble(Numero2.Text);
            double num3 = Convert.ToDouble(Numero3.Text);
            if (num1 + num2 < num3 || num1 == 0 || num2 == 0 || num3 == 0) {
                Resultado.Text = Convert.ToString("Não é triângulo");
            } else if (num1 == num2 && num2 == num3) {
                Resultado.Text = Convert.ToString("É um triângulo equilátero");
            }else if (num1 != num2 && num1 != num3 && num2 != num3) {
                Resultado.Text = Convert.ToString("É um triângulo escaleno");
            }else if((num1 == num2) && (num2 != num3)||(num1 == num3) && (num1 != num2)||(num2 == num3) && (num2 != num1)){
                Resultado.Text = Convert.ToString("É um triângulo isósceles");
            }

            
        }
    }
}
