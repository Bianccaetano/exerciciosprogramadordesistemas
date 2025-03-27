namespace calculodedesconto
{
    partial class frmCalculodesconto
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
            System.Windows.Forms.Label lblValorCompra;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            lblValorCompra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblValorCompra.Location = new System.Drawing.Point(32, 178);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new System.Drawing.Size(154, 16);
            lblValorCompra.TabIndex = 2;
            lblValorCompra.Text = "Insira o valor da compra:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(130, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Cálculo de Desconto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 130);
            this.panel1.TabIndex = 1;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.ForeColor = System.Drawing.Color.White;
            this.txtValorCompra.Location = new System.Drawing.Point(203, 178);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 22);
            this.txtValorCompra.TabIndex = 3;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(32, 248);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(112, 16);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Insira o desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.White;
            this.txtDesconto.Location = new System.Drawing.Point(203, 242);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(203, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(32, 372);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(238, 16);
            this.lblValorFinal.TabIndex = 7;
            this.lblValorFinal.Text = "Resultado da compra com desconto: $";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(268, 372);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 8;
            // 
            // frmCalculodesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(lblValorCompra);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculodesconto";
            this.Text = "Cálculo de Desconto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblResultado;
    }
}

