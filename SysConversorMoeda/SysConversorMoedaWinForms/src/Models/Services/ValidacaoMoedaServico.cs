using SysConversorMoedaWinForms.src.Models.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Models.Services
{
    public class ValidacaoMoedaServico
    {
        public static void ValidarMoedas(string codigoDe, string codigoPara, TextBox txbMoedaDe, TextBox txbMoedaPara, List<Moeda> moedas)
        {
            CultureInfo[] culturas = { new CultureInfo("pt-BR"),
                                       new CultureInfo("en-US")};

            decimal moedaDe = Convert.ToDecimal(txbMoedaDe.Text);
            decimal moedaPara = 0M;

            if(codigoDe == codigoPara)
            {
                txbMoedaPara.Text = txbMoedaDe.Text;
            }
            else if(codigoDe == "BTC")
            {                
                foreach (var moeda in moedas)
                {
                    if (codigoPara == "EUR")
                    {
                        moeda.ValorConvertido = moeda.ValorConvertido.Remove(moeda.ValorConvertido.Length-1);
                    }
                    moedaPara = moedaDe * Convert.ToDecimal(moeda.ValorConvertido, culturas[0]);         
                }

                txbMoedaPara.Text = String.Format("{0:N2}", moedaPara);
            }
            else if(codigoPara == "BTC")
            {
                foreach(var moeda in moedas)
                {
                    if (codigoDe == "EUR")
                    {
                        moeda.ValorConvertido = moeda.ValorConvertido.Remove(moeda.ValorConvertido.Length - 1);
                    }
                    moedaPara = moedaDe / Convert.ToDecimal(moeda.ValorConvertido, culturas[0]);
                }

                txbMoedaPara.Text = String.Format("{0:N8}", moedaPara);
            }
            else
            {
                foreach(var moeda in moedas)
                {
                    moedaPara = moedaDe * Convert.ToDecimal(moeda.ValorConvertido, culturas[1]);
                }

                txbMoedaPara.Text = String.Format("{0:N2}", moedaPara);
            }
        }
    }
}
