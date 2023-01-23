using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Models.Services
{
    public class AdicionarToolTipService
    {
        private static ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Define a duração que o tip aparecerá, permanecerá em exibição e voltará a aparecer quando o mouse passar sobre um ícone.
        /// </summary>
        private static void SetTimeToolTip()
        {
            _toolTip.AutomaticDelay = 600;
            _toolTip.AutoPopDelay = 3000;
            _toolTip.ReshowDelay = 500;
            _toolTip.ShowAlways = true;
        }

        private static void SetToolTip(PictureBox pictureBox, string informacao)
        {
            _toolTip.SetToolTip(pictureBox, informacao);
        }

        public static void SetToolTipPictureBox(PictureBox pictureBox, string informacao)
        {
            SetTimeToolTip();
            SetToolTip(pictureBox, informacao);
        }
    }
}
