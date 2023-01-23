using SysConversorMoedaWinForms.src.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Forms
{
    public partial class FrmSobre : Form
    {
        private string _url = string.Empty;

        public FrmSobre()
        {
            InitializeComponent();
        }

        private void BtnFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
