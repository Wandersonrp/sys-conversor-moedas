using SysConversorMoedaWinForms.src.Models.Entities;
using SysConversorMoedaWinForms.src.Models.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Forms
{
    public partial class FrmInicio : Form
    {
        private FrmInformacaoCliqueConverter _frmInformacao = new FrmInformacaoCliqueConverter();
        private FrmSobre _frmSobre = new FrmSobre();
        private List<Moeda> _listaMoeda;

        private static string _url = string.Empty;
        private static string _codigoMoedaDe = "BRL";               
        private static string _codigoMoedaPara = string.Empty;
        private static string _caminho = AppDomain.CurrentDomain.BaseDirectory + "img\\";
        private static string _nomeArquivoDe = string.Empty;
        private static string _nomeArquivoPara = string.Empty;

        private static bool _trocado = false;
        
        public FrmInicio()
        {
            InitializeComponent();            
        }

        private void PcbSairClick(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void FrmInicioLoad(object sender, EventArgs e)
        {
            _codigoMoedaDe = "BRL";
            _codigoMoedaPara = "BRL";
            _nomeArquivoDe = Path.GetFileName(_caminho + "icon_BRL_64px.png");
            _nomeArquivoPara = Path.GetFileName(_caminho + "icon_BRL_64px.png");
            txbMoedaDe.Text = "0,00";
            txbMoedaPara.Text = "0,00";
            txbMoedaDe.SelectionStart = 4;
            CarregarToolTips();
        }

        private void BtnConverterClick(object sender, EventArgs e)
        {
            _url = ValidacaoUrlServico.ValidarUrl(_codigoMoedaDe, _codigoMoedaPara);
            _listaMoeda = new List<Moeda>();

            ConsumoApiConversorMoeda.ConsumirApiConversorMoeda(_url, _listaMoeda, txbMoedaDe, txbMoedaPara, _codigoMoedaDe, _codigoMoedaPara);
        }

        private void PcbDeRealClick(object sender, EventArgs e)
        {
            _codigoMoedaDe = "BRL";            
            _nomeArquivoDe = Path.GetFileName(_caminho + "icon_BRL_64px.png");
            AtribuicaoMoeda.AtribuirMoedaDe(pcbConverteDe, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
        }

        private void PcbDeDolarClick(object sender, EventArgs e)
        {
            _codigoMoedaDe = "USD";           
            _nomeArquivoDe = Path.GetFileName(_caminho + "icon_USD_64px.png");
            AtribuicaoMoeda.AtribuirMoedaDe(pcbConverteDe, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
        }

        private void PcbDeEuroClick(object sender, EventArgs e)
        {
            _codigoMoedaDe = "EUR";            
            _nomeArquivoDe = Path.GetFileName(_caminho + "icon_EUR_64px.png");
            AtribuicaoMoeda.AtribuirMoedaDe(pcbConverteDe, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
        }

        private void PbDeBitcoinClick(object sender, EventArgs e)
        {
            _codigoMoedaDe = "BTC";           
            _nomeArquivoDe = Path.GetFileName(_caminho + "icon_BTC_64px.png");
            AtribuicaoMoeda.AtribuirMoedaDe(pcbConverteDe, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
        }

        private void PcbParaRealClick(object sender, EventArgs e)
        {
            _codigoMoedaPara = "BRL";                        
            _nomeArquivoPara = Path.GetFileName(_caminho + "icon_BRL_64px.png");
            AtribuicaoMoeda.AtribuirMoedaPara(pcbConvertePara, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
        }

        private void PcbParaDolarClick(object sender, EventArgs e)
        {
            _codigoMoedaPara = "USD";            
            _nomeArquivoPara = Path.GetFileName(_caminho + "icon_USD_64px.png");
            AtribuicaoMoeda.AtribuirMoedaPara(pcbConvertePara, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
        }

        private void PcbParaEuroClick(object sender, EventArgs e)
        {
            _codigoMoedaPara = "EUR";            
            _nomeArquivoPara = Path.GetFileName(_caminho + "icon_EUR_64px.png");
            AtribuicaoMoeda.AtribuirMoedaPara(pcbConvertePara, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
        }        

        private void PcbParaBitcoinClick(object sender, EventArgs e)
        {
            _codigoMoedaPara = "BTC";            
            _nomeArquivoPara = Path.GetFileName(_caminho + "icon_BTC_64px.png");
            AtribuicaoMoeda.AtribuirMoedaPara(pcbConvertePara, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
        }
        private void TxbMoedaDeClick(object sender, EventArgs e)
        {
            txbMoedaDe.SelectionStart = txbMoedaDe.Text.Length + 1;            
        }

        private void TxbMoedaDeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox txb = (TextBox)sender; 
                
                if(txb.Text.Length == 12)
                {
                    return;
                }

                string texto = Regex.Replace(txb.Text, "[^0-9]", string.Empty);

                if (texto == string.Empty) { texto = "00"; }

                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    texto = texto.Substring(0, texto.Length - 1);
                }
                else
                {
                    texto += e.KeyChar;
                }

                txb.Text = string.Format("{0:#,###,###,###,###,##0.00}", decimal.Parse(texto) / 100);
                txb.Select(txb.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void PcbTrocarClick(object sender, EventArgs e)
        {
            if(txbMoedaPara.Text == "0,00" && _codigoMoedaDe != _codigoMoedaPara)
            {
                _frmInformacao.ShowDialog();
            }
            else
            {
                string auxiliar = _codigoMoedaDe;
                _codigoMoedaDe = _codigoMoedaPara;
                _codigoMoedaPara = auxiliar;

                if (_trocado == false)
                {
                    AtribuicaoMoeda.AtribuirMoedaDe(pcbConvertePara, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
                    AtribuicaoMoeda.AtribuirMoedaPara(pcbConverteDe, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
                    _trocado = true;
                    pcbDeReal.Enabled = false;
                    pcbDeDolar.Enabled = false;
                    pcbDeEuro.Enabled = false;
                    pcbDeBitcoin.Enabled = false;
                    pcbParaReal.Enabled = false;
                    pcbParaDolar.Enabled = false;
                    pcbParaEuro.Enabled = false;
                    pcbParaBitcoin.Enabled = false;

                    BtnConverterClick(sender, e);
                }
                else
                {
                    AtribuicaoMoeda.AtribuirMoedaDe(pcbConverteDe, _caminho, _nomeArquivoDe, lblCodigoMoedaDe, _codigoMoedaDe);
                    AtribuicaoMoeda.AtribuirMoedaPara(pcbConvertePara, _caminho, _nomeArquivoPara, lblCodigoMoedaPara, _codigoMoedaPara);
                    _trocado = false;
                    pcbDeReal.Enabled = true;
                    pcbDeDolar.Enabled = true;
                    pcbDeEuro.Enabled = true;
                    pcbDeBitcoin.Enabled = true;
                    pcbParaReal.Enabled = true;
                    pcbParaDolar.Enabled = true;
                    pcbParaEuro.Enabled = true;
                    pcbParaBitcoin.Enabled = true;

                    BtnConverterClick(sender, e);
                }
            }
        }

        private void BtnConverterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnConverterClick(sender, e);
            }
        }

        private void CarregarToolTips()
        {
            AdicionarToolTipService.SetToolTipPictureBox(pcbDeReal, "Real Brasileiro - BRL");
            AdicionarToolTipService.SetToolTipPictureBox(pcbDeDolar, "Dólar Americano - USD");
            AdicionarToolTipService.SetToolTipPictureBox(pcbDeEuro, "Euro - EUR");
            AdicionarToolTipService.SetToolTipPictureBox(pcbDeBitcoin, "Bitcoin - BTC");
            AdicionarToolTipService.SetToolTipPictureBox(pcbParaReal, "Real Brasileiro - BRL");
            AdicionarToolTipService.SetToolTipPictureBox(pcbParaDolar, "Dólar Americano - USD");
            AdicionarToolTipService.SetToolTipPictureBox(pcbParaEuro, "Euro - EUR");
            AdicionarToolTipService.SetToolTipPictureBox(pcbParaBitcoin, "Bitcoin - BTC");
            AdicionarToolTipService.SetToolTipPictureBox(pcbSobre, "Informações");
        }

        //private void PcbModoNoturnoClick(object sender, EventArgs e)
        //{
        //    if(_modoNoturno == false)
        //    {
        //        pcbModoNoturno.Image = Image.FromFile(_caminho + "icon_sun_32px.png");
        //        _modoNoturno = true;
        //        this.BackColor = Color.Black;
        //        pnlDe.BackColor = Color.DimGray;
        //        pnlPara.BackColor = Color.DimGray;
        //        btnConverter.BackColor = Color.Black;                
        //        _frm.BackColor = Color.DimGray;
        //        _frm.pnlTitulo.BackColor = Color.Black;
        //        _frm.lblTituloErro.ForeColor = Color.White;                
        //        _frm.btnFechar.BackColor = Color.Black;
        //    }
        //    else
        //    {
        //        pcbModoNoturno.Image = Image.FromFile(_caminho + "icon_moon_32px.png");
        //        _modoNoturno = false;
        //        this.BackColor = Color.LightSeaGreen;
        //        pnlDe.BackColor = Color.MediumTurquoise;
        //        pnlPara.BackColor = Color.MediumTurquoise;
        //        btnConverter.BackColor = Color.LightSeaGreen;
        //        _frm.BackColor = Color.White;
        //        _frm.pnlTitulo.BackColor = Color.LightSeaGreen;
        //        _frm.lblTituloErro.ForeColor = Color.LightSeaGreen;
        //        _frm.btnFechar.BackColor = Color.LightSeaGreen;
        //    }
        //}

        private void PcbSobreClick(object sender, EventArgs e)
        {
            _frmSobre.ShowDialog();
        }
       
        private void AtribuiZeroAoClicar()
        {
            //txbMoedaDe.Text = "0,00";
            //txbMoedaPara.Text = "0,00";
        }
    }
}
