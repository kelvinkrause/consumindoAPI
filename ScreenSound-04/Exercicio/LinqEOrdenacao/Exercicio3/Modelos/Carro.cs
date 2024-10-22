using System.Text.Json.Serialization;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio3.Modelos
{
    public class Carro
    {
        /*
        "marca": "Toyota",
        "modelo": "Corolla",
        "ano": 2022,
        "tipo": "Sedan",
        "motor": "1.8L",
        "transmissao": "Automática" 
        */     

        [JsonPropertyName("marca")]
        public string? Marca { get; set; }
        [JsonPropertyName("modelo")]
        public string? Modelos { get; set; }
        [JsonPropertyName("ano")]
        public int? Ano { get; set; }

        public void ExibeInformacoesCarro()
        {
            Console.WriteLine($"Carro: {Marca} -> {Modelos}, {Ano}");
        }

    }
}