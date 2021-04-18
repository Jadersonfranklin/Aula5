using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Receba três valores double que são os valores de a, b e c numa 
        //equação de segundo grau(ax²+bx+c= 0) e imprima na tela:
        //1 - Não é equação do segundo grau(a = 0);
        //2 - Não possui raízes em R(∆<0);
        //3 - Possui uma raíz e é _____(calcular);
        //4 - Possui duas raízes e são _____ e _____(calcular);
        private void buttonIgual_Click(object sender, EventArgs e) {
            double a = Convert.ToDouble(Numero1.Text);
            double b = Convert.ToDouble(Numero2.Text);
            double c = Convert.ToDouble(Numero3.Text);
            int x = 2;
            double equacao = a * (x ^ 2) + (b * x) + c;
            double x1 = (-b + (equacao / equacao)) / (2 * a);
            double x2 = (-b - (equacao / equacao)) / (2 * a);

            if(a == 0) {
                Resultado.Text = Convert.ToString("Não é equação de segundo grau");
            }else if(equacao < 0) {
                Resultado.Text = Convert.ToString("Não possui raizes em R");
            }else if(equacao == 0) {
                Resultado.Text = Convert.ToString("Possui UMA raizes em R" +"X1 = " + x2);
            }else if(equacao > 0) {
                Resultado.Text = Convert.ToString("Possui Duas raizes em R: "+"X1 = " + x1 + " " + "X2 = " + x2);
            }
        }
    }
}
