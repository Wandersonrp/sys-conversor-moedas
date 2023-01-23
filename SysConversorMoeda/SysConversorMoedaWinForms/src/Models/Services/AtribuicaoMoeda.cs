using System.Drawing;
using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Models.Services
{
    public class AtribuicaoMoeda
    {
        public static void AtribuirMoedaDe(PictureBox pictureBox, string caminhoBase, string nomeArquivo, Label lblCodigoMoedaDe, string codigoMoedaDe)
        {
            lblCodigoMoedaDe.Text = codigoMoedaDe;
            pictureBox.Image = Image.FromFile(caminhoBase + nomeArquivo);
        }

        public static void AtribuirMoedaPara(PictureBox pictureBox, string caminhoBase, string nomeArquivo, Label lblCodigoMoedaPara, string codigoMoedaPara)
        {
            lblCodigoMoedaPara.Text = codigoMoedaPara;
            pictureBox.Image = Image.FromFile(caminhoBase + nomeArquivo);
        }

        
    }
}
