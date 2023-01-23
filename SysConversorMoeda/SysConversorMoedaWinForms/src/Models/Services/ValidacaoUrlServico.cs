namespace SysConversorMoedaWinForms.src.Models.Services
{
    public class ValidacaoUrlServico
    {
        /// <summary>
        /// Método para validar a Url da Api Awesomeapi.
        /// </summary>
        /// <param name="codigoMoedaDe"></param>
        /// <param name="codigoMoedaPara"></param>
        /// <returns></returns>
        public static string ValidarUrl(string codigoMoedaDe, string codigoMoedaPara)
        {
            string url = string.Empty;

            if(codigoMoedaPara == "BTC" )
            {
                url = $"https://economia.awesomeapi.com.br/json/{codigoMoedaPara}-{codigoMoedaDe}";
            }
            else
            {
                url = $"https://economia.awesomeapi.com.br/json/{codigoMoedaDe}-{codigoMoedaPara}";
            }
            return url;
        }
    }
}
