namespace SysConversorMoedaWinForms.src.Forms
{
    partial class FrmInformacaoCliqueConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacaoCliqueConverter));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloErro = new System.Windows.Forms.Label();
            this.pcbInformacao = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInformacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(570, 43);
            this.pnlTitulo.TabIndex = 2;
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
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(226, 209);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 41);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
            // 
            // lblTituloErro
            // 
            this.lblTituloErro.AutoSize = true;
            this.lblTituloErro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloErro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTituloErro.Location = new System.Drawing.Point(131, 116);
            this.lblTituloErro.Name = "lblTituloErro";
            this.lblTituloErro.Size = new System.Drawing.Size(323, 32);
            this.lblTituloErro.TabIndex = 4;
            this.lblTituloErro.Text = "Clique no botão converter!";
            // 
            // pcbInformacao
            // 
            this.pcbInformacao.Image = ((System.Drawing.Image)(resources.GetObject("pcbInformacao.Image")));
            this.pcbInformacao.Location = new System.Drawing.Point(38, 101);
            this.pcbInformacao.Name = "pcbInformacao";
            this.pcbInformacao.Size = new System.Drawing.Size(64, 60);
            this.pcbInformacao.TabIndex = 5;
            this.pcbInformacao.TabStop = false;
            // 
            // FrmInformacaoCliqueConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.pcbInformacao);
            this.Controls.Add(this.lblTituloErro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformacaoCliqueConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInformacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlTitulo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Label lblTituloErro;
        private System.Windows.Forms.PictureBox pcbInformacao;
    }
}