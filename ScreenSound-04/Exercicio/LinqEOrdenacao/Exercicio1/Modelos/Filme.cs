using System.Text.Json.Serialization;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio1.Modelos
{
    public class Filme
    {
        [JsonPropertyName("title")]
        public string? Nome { get; set; }
        [JsonPropertyName("year")]
        public string? AnoLancamento { get; set; }
    }
}