namespace Exercicio14
{
    partial class FrmCalcPrecoUnit
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
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.lblValorProd = new System.Windows.Forms.Label();
            this.butCalc = new System.Windows.Forms.Button();
            this.lblFatorEmb = new System.Windows.Forms.Label();
            this.txtFatorEmb = new System.Windows.Forms.TextBox();
            this.lblCasasDec = new System.Windows.Forms.Label();
            this.txtCasasDec = new System.Windows.Forms.TextBox();
            this.lblPrecoUnit = new System.Windows.Forms.Label();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValorProd
            // 
            this.txtValorProd.Location = new System.Drawing.Point(22, 35);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(100, 20);
            this.txtValorProd.TabIndex = 0;
            // 
            // lblValorProd
            // 
            this.lblValorProd.AutoSize = true;
            this.lblValorProd.Location = new System.Drawing.Point(19, 19);
            this.lblValorProd.Name = "lblValorProd";
            this.lblValorProd.Size = new System.Drawing.Size(88, 13);
            this.lblValorProd.TabIndex = 1;
            this.lblValorProd.Text = "Valor do produto:";
            // 
            // butCalc
            // 
            this.butCalc.Location = new System.Drawing.Point(158, 84);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(100, 20);
            this.butCalc.TabIndex = 3;
            this.butCalc.Text = "Calcular";
            this.butCalc.UseVisualStyleBackColor = true;
            this.butCalc.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // lblFatorEmb
            // 
            this.lblFatorEmb.AutoSize = true;
            this.lblFatorEmb.Location = new System.Drawing.Point(155, 19);
            this.lblFatorEmb.Name = "lblFatorEmb";
            this.lblFatorEmb.Size = new System.Drawing.Size(106, 13);
            this.lblFatorEmb.TabIndex = 4;
            this.lblFatorEmb.Text = "Fator de embalagem:";
            // 
            // txtFatorEmb
            // 
            this.txtFatorEmb.Location = new System.Drawing.Point(158, 35);
            this.txtFatorEmb.Name = "txtFatorEmb";
            this.txtFatorEmb.Size = new System.Drawing.Size(100, 20);
            this.txtFatorEmb.TabIndex = 1;
            // 
            // lblCasasDec
            // 
            this.lblCasasDec.AutoSize = true;
            this.lblCasasDec.Location = new System.Drawing.Point(19, 68);
            this.lblCasasDec.Name = "lblCasasDec";
            this.lblCasasDec.Size = new System.Drawing.Size(83, 13);
            this.lblCasasDec.TabIndex = 6;
            this.lblCasasDec.Text = "Casas decimais:";
            // 
            // txtCasasDec
            // 
            this.txtCasasDec.Location = new System.Drawing.Point(22, 84);
            this.txtCasasDec.Name = "txtCasasDec";
            this.txtCasasDec.Size = new System.Drawing.Size(100, 20);
            this.txtCasasDec.TabIndex = 2;
            // 
            // lblPrecoUnit
            // 
            this.lblPrecoUnit.AutoSize = true;
            this.lblPrecoUnit.Location = new System.Drawing.Point(19, 123);
            this.lblPrecoUnit.Name = "lblPrecoUnit";
            this.lblPrecoUnit.Size = new System.Drawing.Size(75, 13);
            this.lblPrecoUnit.TabIndex = 7;
            this.lblPrecoUnit.Text = "Preço unitário:";
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Location = new System.Drawing.Point(22, 139);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.ReadOnly = true;
            this.txtPrecoUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnit.TabIndex = 4;
            // 
            // FrmCalcPrecoUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.lblPrecoUnit);
            this.Controls.Add(this.lblCasasDec);
            this.Controls.Add(this.txtCasasDec);
            this.Controls.Add(this.lblFatorEmb);
            this.Controls.Add(this.txtFatorEmb);
            this.Controls.Add(this.butCalc);
            this.Controls.Add(this.lblValorProd);
            this.Controls.Add(this.txtValorProd);
            this.Name = "FrmCalcPrecoUnit";
            this.Text = "Cálculo de preço unitário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.Label lblValorProd;
        private System.Windows.Forms.Button butCalc;
        private System.Windows.Forms.Label lblFatorEmb;
        private System.Windows.Forms.TextBox txtFatorEmb;
        private System.Windows.Forms.Label lblCasasDec;
        private System.Windows.Forms.TextBox txtCasasDec;
        private System.Windows.Forms.Label lblPrecoUnit;
        private System.Windows.Forms.TextBox txtPrecoUnit;
    }
}

