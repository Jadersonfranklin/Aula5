using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Receba do usuário três números inteiros e imprima na tela o maior, o menor, a sua média e a sua soma
        private void buttonMedia_Click(object sender, EventArgs e) {
            int num1 = Convert.ToInt32(Numero1.Text);
            int num2 = Convert.ToInt32(Numero2.Text);
            int num3 = Convert.ToInt32(Numero3.Text);
            int media = (num1 + num2 + num3) / 3;
            Imprimir.Text = Convert.ToString(media);
        }

        private void buttonMaior_Click(object sender, EventArgs e) {
            int num1 = Convert.ToInt32(Numero1.Text);
            int num2 = Convert.ToInt32(Numero2.Text);
            int num3 = Convert.ToInt32(Numero3.Text);

            if (num1 > num2) {
                if (num1 > num3) Imprimir.Text = Convert.ToString(num1);
                else Imprimir.Text = Convert.ToString(num3);
            } else {
                if (num2 > num3) Imprimir.Text = Convert.ToString(num2);
                else Imprimir.Text = Convert.ToString(num3);

            }
        }
        private void buttonSoma_Click(object sender, EventArgs e) {
            int num1 = Convert.ToInt32(Numero1.Text);
            int num2 = Convert.ToInt32(Numero2.Text);
            int num3 = Convert.ToInt32(Numero3.Text);
            int soma = (num1 + num2 + num3);
            Imprimir.Text = Convert.ToString(soma);
        }

        private void buttonMenor_Click(object sender, EventArgs e) {
            int num1 = Convert.ToInt32(Numero1.Text);
            int num2 = Convert.ToInt32(Numero2.Text);
            int num3 = Convert.ToInt32(Numero3.Text);

            if (num1 < num2) {
                if (num1 < num3) Imprimir.Text = Convert.ToString(num1);
                else Imprimir.Text = Convert.ToString(num3);
            } else {
                if (num2 < num3) Imprimir.Text = Convert.ToString(num2);
                else Imprimir.Text = Convert.ToString(num3);

            }
        }
    }
}
