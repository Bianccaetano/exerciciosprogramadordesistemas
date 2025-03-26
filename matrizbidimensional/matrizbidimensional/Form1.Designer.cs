
namespace matrizbidimensional
{
    partial class frmMatrizBidimensional
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
            this.txtMatrizBidimensional = new System.Windows.Forms.TextBox();
            this.btnExibirValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatrizBidimensional
            // 
            this.txtMatrizBidimensional.BackColor = System.Drawing.Color.White;
            this.txtMatrizBidimensional.Enabled = false;
            this.txtMatrizBidimensional.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrizBidimensional.Location = new System.Drawing.Point(174, 123);
            this.txtMatrizBidimensional.Multiline = true;
            this.txtMatrizBidimensional.Name = "txtMatrizBidimensional";
            this.txtMatrizBidimensional.ReadOnly = true;
            this.txtMatrizBidimensional.Size = new System.Drawing.Size(123, 112);
            this.txtMatrizBidimensional.TabIndex = 0;
            this.txtMatrizBidimensional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExibirValor
            // 
            this.btnExibirValor.BackColor = System.Drawing.Color.White;
            this.btnExibirValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirValor.Location = new System.Drawing.Point(154, 291);
            this.btnExibirValor.Name = "btnExibirValor";
            this.btnExibirValor.Size = new System.Drawing.Size(161, 51);
            this.btnExibirValor.TabIndex = 1;
            this.btnExibirValor.Text = "Exibir maior valor";
            this.btnExibirValor.UseVisualStyleBackColor = false;
            this.btnExibirValor.Click += new System.EventHandler(this.btnExibirValor_Click);
            // 
            // frmMatrizBidimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.btnExibirValor);
            this.Controls.Add(this.txtMatrizBidimensional);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMatrizBidimensional";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMatrizBidimensional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrizBidimensional;
        private System.Windows.Forms.Button btnExibirValor;
    }
}

