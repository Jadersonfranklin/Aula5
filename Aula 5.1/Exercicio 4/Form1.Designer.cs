
namespace Exercicio_4 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Numero3 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(227, 46);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(100, 20);
            this.Numero1.TabIndex = 0;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(227, 81);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 20);
            this.Numero2.TabIndex = 1;
            // 
            // Numero3
            // 
            this.Numero3.Location = new System.Drawing.Point(227, 118);
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(100, 20);
            this.Numero3.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(227, 155);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(223, 20);
            this.Resultado.TabIndex = 3;
            // 
            // buttonIgual
            // 
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonIgual.Location = new System.Drawing.Point(375, 93);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(75, 35);
            this.buttonIgual.TabIndex = 4;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero3);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.TextBox Numero3;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button buttonIgual;
    }
}

