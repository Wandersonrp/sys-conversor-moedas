namespace SysConversorMoedaWinForms.src.Forms
{
    partial class FrmErroResponse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErroResponse));
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloErro = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.pcbInformacao = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInformacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(219, 209);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 41);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ops!";
            // 
            // lblTituloErro
            // 
            this.lblTituloErro.AutoSize = true;
            this.lblTituloErro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloErro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTituloErro.Location = new System.Drawing.Point(177, 62);
            this.lblTituloErro.Name = "lblTituloErro";
            this.lblTituloErro.Size = new System.Drawing.Size(214, 32);
            this.lblTituloErro.TabIndex = 2;
            this.lblTituloErro.Text = "Ocorreu um erro!";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblErro.Location = new System.Drawing.Point(15, 136);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(49, 21);
            this.lblErro.TabIndex = 3;
            this.lblErro.Text = "Erro: ";
            // 
            // pcbInformacao
            // 
            this.pcbInformacao.Image = ((System.Drawing.Image)(resources.GetObject("pcbInformacao.Image")));
            this.pcbInformacao.Location = new System.Drawing.Point(33, 47);
            this.pcbInformacao.Name = "pcbInformacao";
            this.pcbInformacao.Size = new System.Drawing.Size(64, 67);
            this.pcbInformacao.TabIndex = 6;
            this.pcbInformacao.TabStop = false;
            // 
            // FrmErroResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.pcbInformacao);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblTituloErro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmErroResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmErroResponse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInformacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloErro;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox pcbInformacao;
    }
}