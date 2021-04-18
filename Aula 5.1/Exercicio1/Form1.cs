using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Receba do usuário dois números inteiros e imprima na tela sua soma;
        private void Igual_Click(object sender, EventArgs e) {
            int num1 = Int32.Parse(Numero1.Text);
            int num2 = Int32.Parse(Numero2.Text);
            int resultado = num1 + num2;
            Resultado.Text = Convert.ToString(resultado);
        }
    }
}
