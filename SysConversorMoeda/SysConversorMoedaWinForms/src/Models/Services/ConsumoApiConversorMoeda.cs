using Newtonsoft.Json;
using SysConversorMoedaWinForms.src.Forms;
using SysConversorMoedaWinForms.src.Models.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysConversorMoedaWinForms.src.Models.Services
{
    public class ConsumoApiConversorMoeda
    {
        /// <summary>
        /// Método que consome a Api de conversão de moedas Awesomeapi.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="moeda"></param>
        /// <param name="txbMoedaDe"></param>
        /// <param name="txbMoedaPara"></param>
        /// <returns></returns>
        public static async Task ConsumirApiConversorMoeda(string url, List<Moeda> moedas, TextBox txbMoedaDe,TextBox txbMoedaPara, string codigoMoedaDe, string codigoMoedaPara)
        {                       
            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await cliente.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    moedas = JsonConvert.DeserializeObject<List<Moeda>>(json);
                }
                catch(Exception ex)
                {
                    if (codigoMoedaDe != codigoMoedaPara)
                    {
                        FrmErroResponse frmErro = new FrmErroResponse(ex.Message);
                        frmErro.ShowDialog();
                    }                    
                }
                finally
                {
                    ValidacaoMoedaServico.ValidarMoedas(codigoMoedaDe, codigoMoedaPara, txbMoedaDe, txbMoedaPara, moedas);
                }
            }
        }
    }
}
