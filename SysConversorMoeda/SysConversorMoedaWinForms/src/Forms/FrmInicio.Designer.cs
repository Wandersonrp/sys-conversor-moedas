namespace SysConversorMoedaWinForms.src.Forms
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pnlDe = new System.Windows.Forms.Panel();
            this.pcbDeBitcoin = new System.Windows.Forms.PictureBox();
            this.pcbDeEuro = new System.Windows.Forms.PictureBox();
            this.pcbDeDolar = new System.Windows.Forms.PictureBox();
            this.pcbDeReal = new System.Windows.Forms.PictureBox();
            this.pcbParaReal = new System.Windows.Forms.PictureBox();
            this.pnlPara = new System.Windows.Forms.Panel();
            this.pcbParaBitcoin = new System.Windows.Forms.PictureBox();
            this.pcbParaEuro = new System.Windows.Forms.PictureBox();
            this.pcbParaDolar = new System.Windows.Forms.PictureBox();
            this.gpbConverte = new System.Windows.Forms.GroupBox();
            this.lblCodigoMoedaPara = new System.Windows.Forms.Label();
            this.lblCodigoMoedaDe = new System.Windows.Forms.Label();
            this.pcbTrocar = new System.Windows.Forms.PictureBox();
            this.txbMoedaPara = new System.Windows.Forms.TextBox();
            this.txbMoedaDe = new System.Windows.Forms.TextBox();
            this.pcbConvertePara = new System.Windows.Forms.PictureBox();
            this.pcbConverteDe = new System.Windows.Forms.PictureBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbSobre = new System.Windows.Forms.PictureBox();
            this.pnlDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeBitcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeDolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaReal)).BeginInit();
            this.pnlPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaBitcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaDolar)).BeginInit();
            this.gpbConverte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrocar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConvertePara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConverteDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDe
            // 
            this.pnlDe.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlDe.Controls.Add(this.pcbDeBitcoin);
            this.pnlDe.Controls.Add(this.pcbDeEuro);
            this.pnlDe.Controls.Add(this.pcbDeDolar);
            this.pnlDe.Controls.Add(this.pcbDeReal);
            this.pnlDe.Location = new System.Drawing.Point(24, 65);
            this.pnlDe.Name = "pnlDe";
            this.pnlDe.Size = new System.Drawing.Size(351, 107);
            this.pnlDe.TabIndex = 0;
            // 
            // pcbDeBitcoin
            // 
            this.pcbDeBitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDeBitcoin.Image = ((System.Drawing.Image)(resources.GetObject("pcbDeBitcoin.Image")));
            this.pcbDeBitcoin.Location = new System.Drawing.Point(266, 22);
            this.pcbDeBitcoin.Name = "pcbDeBitcoin";
            this.pcbDeBitcoin.Size = new System.Drawing.Size(67, 64);
            this.pcbDeBitcoin.TabIndex = 5;
            this.pcbDeBitcoin.TabStop = false;
            this.pcbDeBitcoin.Click += new System.EventHandler(this.PbDeBitcoinClick);
            // 
            // pcbDeEuro
            // 
            this.pcbDeEuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDeEuro.Image = ((System.Drawing.Image)(resources.GetObject("pcbDeEuro.Image")));
            this.pcbDeEuro.Location = new System.Drawing.Point(181, 22);
            this.pcbDeEuro.Name = "pcbDeEuro";
            this.pcbDeEuro.Size = new System.Drawing.Size(67, 64);
            this.pcbDeEuro.TabIndex = 4;
            this.pcbDeEuro.TabStop = false;
            this.pcbDeEuro.Click += new System.EventHandler(this.PcbDeEuroClick);
            // 
            // pcbDeDolar
            // 
            this.pcbDeDolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDeDolar.Image = ((System.Drawing.Image)(resources.GetObject("pcbDeDolar.Image")));
            this.pcbDeDolar.Location = new System.Drawing.Point(98, 22);
            this.pcbDeDolar.Name = "pcbDeDolar";
            this.pcbDeDolar.Size = new System.Drawing.Size(67, 64);
            this.pcbDeDolar.TabIndex = 3;
            this.pcbDeDolar.TabStop = false;
            this.pcbDeDolar.Click += new System.EventHandler(this.PcbDeDolarClick);
            // 
            // pcbDeReal
            // 
            this.pcbDeReal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbDeReal.Image = ((System.Drawing.Image)(resources.GetObject("pcbDeReal.Image")));
            this.pcbDeReal.Location = new System.Drawing.Point(13, 22);
            this.pcbDeReal.Name = "pcbDeReal";
            this.pcbDeReal.Size = new System.Drawing.Size(67, 64);
            this.pcbDeReal.TabIndex = 2;
            this.pcbDeReal.TabStop = false;
            this.pcbDeReal.Click += new System.EventHandler(this.PcbDeRealClick);
            // 
            // pcbParaReal
            // 
            this.pcbParaReal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbParaReal.Image = ((System.Drawing.Image)(resources.GetObject("pcbParaReal.Image")));
            this.pcbParaReal.Location = new System.Drawing.Point(13, 22);
            this.pcbParaReal.Name = "pcbParaReal";
            this.pcbParaReal.Size = new System.Drawing.Size(67, 64);
            this.pcbParaReal.TabIndex = 2;
            this.pcbParaReal.TabStop = false;
            this.pcbParaReal.Click += new System.EventHandler(this.PcbParaRealClick);
            // 
            // pnlPara
            // 
            this.pnlPara.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlPara.Controls.Add(this.pcbParaBitcoin);
            this.pnlPara.Controls.Add(this.pcbParaEuro);
            this.pnlPara.Controls.Add(this.pcbParaDolar);
            this.pnlPara.Controls.Add(this.pcbParaReal);
            this.pnlPara.Location = new System.Drawing.Point(425, 65);
            this.pnlPara.Name = "pnlPara";
            this.pnlPara.Size = new System.Drawing.Size(351, 107);
            this.pnlPara.TabIndex = 6;
            // 
            // pcbParaBitcoin
            // 
            this.pcbParaBitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbParaBitcoin.Image = ((System.Drawing.Image)(resources.GetObject("pcbParaBitcoin.Image")));
            this.pcbParaBitcoin.Location = new System.Drawing.Point(266, 22);
            this.pcbParaBitcoin.Name = "pcbParaBitcoin";
            this.pcbParaBitcoin.Size = new System.Drawing.Size(67, 64);
            this.pcbParaBitcoin.TabIndex = 5;
            this.pcbParaBitcoin.TabStop = false;
            this.pcbParaBitcoin.Click += new System.EventHandler(this.PcbParaBitcoinClick);
            // 
            // pcbParaEuro
            // 
            this.pcbParaEuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbParaEuro.Image = ((System.Drawing.Image)(resources.GetObject("pcbParaEuro.Image")));
            this.pcbParaEuro.Location = new System.Drawing.Point(181, 22);
            this.pcbParaEuro.Name = "pcbParaEuro";
            this.pcbParaEuro.Size = new System.Drawing.Size(67, 64);
            this.pcbParaEuro.TabIndex = 4;
            this.pcbParaEuro.TabStop = false;
            this.pcbParaEuro.Click += new System.EventHandler(this.PcbParaEuroClick);
            // 
            // pcbParaDolar
            // 
            this.pcbParaDolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbParaDolar.Image = ((System.Drawing.Image)(resources.GetObject("pcbParaDolar.Image")));
            this.pcbParaDolar.Location = new System.Drawing.Point(98, 22);
            this.pcbParaDolar.Name = "pcbParaDolar";
            this.pcbParaDolar.Size = new System.Drawing.Size(67, 64);
            this.pcbParaDolar.TabIndex = 3;
            this.pcbParaDolar.TabStop = false;
            this.pcbParaDolar.Click += new System.EventHandler(this.PcbParaDolarClick);
            // 
            // gpbConverte
            // 
            this.gpbConverte.Controls.Add(this.lblCodigoMoedaPara);
            this.gpbConverte.Controls.Add(this.lblCodigoMoedaDe);
            this.gpbConverte.Controls.Add(this.pcbTrocar);
            this.gpbConverte.Controls.Add(this.txbMoedaPara);
            this.gpbConverte.Controls.Add(this.txbMoedaDe);
            this.gpbConverte.Controls.Add(this.pcbConvertePara);
            this.gpbConverte.Controls.Add(this.pcbConverteDe);
            this.gpbConverte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbConverte.ForeColor = System.Drawing.Color.White;
            this.gpbConverte.Location = new System.Drawing.Point(24, 197);
            this.gpbConverte.Name = "gpbConverte";
            this.gpbConverte.Size = new System.Drawing.Size(752, 152);
            this.gpbConverte.TabIndex = 7;
            this.gpbConverte.TabStop = false;
            this.gpbConverte.Text = "Converter";
            // 
            // lblCodigoMoedaPara
            // 
            this.lblCodigoMoedaPara.AutoSize = true;
            this.lblCodigoMoedaPara.Location = new System.Drawing.Point(680, 121);
            this.lblCodigoMoedaPara.Name = "lblCodigoMoedaPara";
            this.lblCodigoMoedaPara.Size = new System.Drawing.Size(46, 25);
            this.lblCodigoMoedaPara.TabIndex = 11;
            this.lblCodigoMoedaPara.Text = "BRL";
            // 
            // lblCodigoMoedaDe
            // 
            this.lblCodigoMoedaDe.AutoSize = true;
            this.lblCodigoMoedaDe.Location = new System.Drawing.Point(25, 121);
            this.lblCodigoMoedaDe.Name = "lblCodigoMoedaDe";
            this.lblCodigoMoedaDe.Size = new System.Drawing.Size(46, 25);
            this.lblCodigoMoedaDe.TabIndex = 10;
            this.lblCodigoMoedaDe.Text = "BRL";
            // 
            // pcbTrocar
            // 
            this.pcbTrocar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbTrocar.Image = ((System.Drawing.Image)(resources.GetObject("pcbTrocar.Image")));
            this.pcbTrocar.Location = new System.Drawing.Point(360, 69);
            this.pcbTrocar.Name = "pcbTrocar";
            this.pcbTrocar.Size = new System.Drawing.Size(36, 35);
            this.pcbTrocar.TabIndex = 9;
            this.pcbTrocar.TabStop = false;
            this.pcbTrocar.Click += new System.EventHandler(this.PcbTrocarClick);
            // 
            // txbMoedaPara
            // 
            this.txbMoedaPara.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMoedaPara.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txbMoedaPara.Location = new System.Drawing.Point(403, 63);
            this.txbMoedaPara.MaxLength = 10;
            this.txbMoedaPara.Name = "txbMoedaPara";
            this.txbMoedaPara.ReadOnly = true;
            this.txbMoedaPara.Size = new System.Drawing.Size(251, 46);
            this.txbMoedaPara.TabIndex = 8;
            this.txbMoedaPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbMoedaDe
            // 
            this.txbMoedaDe.BackColor = System.Drawing.SystemColors.Window;
            this.txbMoedaDe.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMoedaDe.ForeColor = System.Drawing.Color.Black;
            this.txbMoedaDe.Location = new System.Drawing.Point(98, 63);
            this.txbMoedaDe.MaxLength = 10;
            this.txbMoedaDe.Name = "txbMoedaDe";
            this.txbMoedaDe.Size = new System.Drawing.Size(255, 46);
            this.txbMoedaDe.TabIndex = 7;
            this.txbMoedaDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbMoedaDe.Click += new System.EventHandler(this.TxbMoedaDeClick);
            this.txbMoedaDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbMoedaDeKeyPress);
            // 
            // pcbConvertePara
            // 
            this.pcbConvertePara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbConvertePara.Image = ((System.Drawing.Image)(resources.GetObject("pcbConvertePara.Image")));
            this.pcbConvertePara.Location = new System.Drawing.Point(667, 51);
            this.pcbConvertePara.Name = "pcbConvertePara";
            this.pcbConvertePara.Size = new System.Drawing.Size(67, 64);
            this.pcbConvertePara.TabIndex = 6;
            this.pcbConvertePara.TabStop = false;
            // 
            // pcbConverteDe
            // 
            this.pcbConverteDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbConverteDe.Image = ((System.Drawing.Image)(resources.GetObject("pcbConverteDe.Image")));
            this.pcbConverteDe.Location = new System.Drawing.Point(16, 51);
            this.pcbConverteDe.Name = "pcbConverteDe";
            this.pcbConverteDe.Size = new System.Drawing.Size(67, 64);
            this.pcbConverteDe.TabIndex = 6;
            this.pcbConverteDe.TabStop = false;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConverter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Location = new System.Drawing.Point(276, 388);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(251, 55);
            this.btnConverter.TabIndex = 8;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.BtnConverterClick);
            this.btnConverter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnConverterKeyDown);
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(744, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(32, 36);
            this.pcbSair.TabIndex = 9;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.PcbSairClick);
            // 
            // pcbSobre
            // 
            this.pcbSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSobre.Image = ((System.Drawing.Image)(resources.GetObject("pcbSobre.Image")));
            this.pcbSobre.Location = new System.Drawing.Point(743, 400);
            this.pcbSobre.Name = "pcbSobre";
            this.pcbSobre.Size = new System.Drawing.Size(33, 34);
            this.pcbSobre.TabIndex = 10;
            this.pcbSobre.TabStop = false;
            this.pcbSobre.Click += new System.EventHandler(this.PcbSobreClick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.pcbSobre);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.gpbConverte);
            this.Controls.Add(this.pnlPara);
            this.Controls.Add(this.pnlDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmInicioLoad);
            this.pnlDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeBitcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeDolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaReal)).EndInit();
            this.pnlPara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaBitcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbParaDolar)).EndInit();
            this.gpbConverte.ResumeLayout(false);
            this.gpbConverte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrocar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConvertePara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbConverteDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSobre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDe;
        private System.Windows.Forms.PictureBox pcbDeBitcoin;
        private System.Windows.Forms.PictureBox pcbDeEuro;
        private System.Windows.Forms.PictureBox pcbDeDolar;
        private System.Windows.Forms.PictureBox pcbDeReal;
        private System.Windows.Forms.PictureBox pcbParaReal;
        private System.Windows.Forms.Panel pnlPara;
        private System.Windows.Forms.PictureBox pcbParaBitcoin;
        private System.Windows.Forms.PictureBox pcbParaEuro;
        private System.Windows.Forms.PictureBox pcbParaDolar;
        private System.Windows.Forms.GroupBox gpbConverte;
        private System.Windows.Forms.TextBox txbMoedaPara;
        private System.Windows.Forms.TextBox txbMoedaDe;
        private System.Windows.Forms.PictureBox pcbConvertePara;
        private System.Windows.Forms.PictureBox pcbConverteDe;
        private System.Windows.Forms.PictureBox pcbTrocar;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbSobre;
        private System.Windows.Forms.Label lblCodigoMoedaPara;
        private System.Windows.Forms.Label lblCodigoMoedaDe;
    }
}