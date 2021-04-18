
namespace Exercicio3 {
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
            this.Imprimir = new System.Windows.Forms.TextBox();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.buttonMaior = new System.Windows.Forms.Button();
            this.buttonMenor = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(199, 64);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(100, 20);
            this.Numero1.TabIndex = 0;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(199, 90);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 20);
            this.Numero2.TabIndex = 1;
            // 
            // Numero3
            // 
            this.Numero3.Location = new System.Drawing.Point(199, 116);
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(100, 20);
            this.Numero3.TabIndex = 2;
            // 
            // Imprimir
            // 
            this.Imprimir.Location = new System.Drawing.Point(199, 151);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(100, 20);
            this.Imprimir.TabIndex = 3;
            // 
            // buttonMedia
            // 
            this.buttonMedia.Location = new System.Drawing.Point(351, 64);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(75, 23);
            this.buttonMedia.TabIndex = 4;
            this.buttonMedia.Text = "Media";
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.buttonMedia_Click);
            // 
            // buttonMaior
            // 
            this.buttonMaior.Location = new System.Drawing.Point(351, 93);
            this.buttonMaior.Name = "buttonMaior";
            this.buttonMaior.Size = new System.Drawing.Size(75, 23);
            this.buttonMaior.TabIndex = 5;
            this.buttonMaior.Text = "Maior";
            this.buttonMaior.UseVisualStyleBackColor = true;
            this.buttonMaior.Click += new System.EventHandler(this.buttonMaior_Click);
            // 
            // buttonMenor
            // 
            this.buttonMenor.Location = new System.Drawing.Point(351, 122);
            this.buttonMenor.Name = "buttonMenor";
            this.buttonMenor.Size = new System.Drawing.Size(75, 23);
            this.buttonMenor.TabIndex = 6;
            this.buttonMenor.Text = "Menor";
            this.buttonMenor.UseVisualStyleBackColor = true;
            this.buttonMenor.Click += new System.EventHandler(this.buttonMenor_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(351, 151);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(75, 23);
            this.buttonSoma.TabIndex = 7;
            this.buttonSoma.Text = "Soma";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonMenor);
            this.Controls.Add(this.buttonMaior);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.Imprimir);
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
        private System.Windows.Forms.TextBox Imprimir;
        private System.Windows.Forms.Button buttonMedia;
        private System.Windows.Forms.Button buttonMaior;
        private System.Windows.Forms.Button buttonMenor;
        private System.Windows.Forms.Button buttonSoma;
    }
}

