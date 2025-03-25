
namespace maioroumenorquedez
{
    partial class frmMaiorOuMenorQueDez
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtEntradaDeNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(212, 205);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 32);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtEntradaDeNumero
            // 
            this.txtEntradaDeNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEntradaDeNumero.Location = new System.Drawing.Point(173, 156);
            this.txtEntradaDeNumero.Name = "txtEntradaDeNumero";
            this.txtEntradaDeNumero.Size = new System.Drawing.Size(151, 20);
            this.txtEntradaDeNumero.TabIndex = 1;
            this.txtEntradaDeNumero.Text = "Digite um número ";
            this.txtEntradaDeNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMaiorOuMenorQueDez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.txtEntradaDeNumero);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmMaiorOuMenorQueDez";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtEntradaDeNumero;
    }
}

