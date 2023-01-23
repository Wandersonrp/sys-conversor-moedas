using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Forms
{
    public partial class FrmErroResponse : Form
    {
        public FrmErroResponse()
        {
            InitializeComponent();
        }

        public FrmErroResponse(string mensagem)
        {
            InitializeComponent();
            lblErro.Text = lblErro.Text + mensagem;
        }

        private void BtnFecharClick(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
