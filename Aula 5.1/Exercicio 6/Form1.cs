using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Dado um valor inteiro n, calcule o número triangular para esse valor.
        private void buttonIgual_Click(object sender, EventArgs e) {
            int n = Convert.ToInt32(Numero1.Text);
            int triangular = (n * (n + 1)) / 2;
            Resultado.Text = Convert.ToString(triangular);
        }
    }
}
