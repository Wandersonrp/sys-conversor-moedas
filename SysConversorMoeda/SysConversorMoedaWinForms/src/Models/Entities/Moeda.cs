using Newtonsoft.Json;

namespace SysConversorMoedaWinForms.src.Models.Entities
{
    public class Moeda
    {
        [JsonProperty("code")]
        public string CodigoMoedaDe { get; set; }

        [JsonProperty("codein")]
        public string CodigoMoedaPara { get; set; }

        [JsonProperty("ask")]
        public string ValorConvertido { get; set; }
    }
}
