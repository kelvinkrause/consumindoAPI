using System.Text.Json.Serialization;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Modelos
{
    public class Livro
    {
        /*
        "titulo": "O Senhor dos Anéis",
        "autor": "J.R.R. Tolkien",
        "ano_publicacao": 1954,
        "genero": "Fantasia",
        "paginas": 1178,
        "editora": "Martins Fontes"
        */

        [JsonPropertyName("titulo")]
        public string? Titulos { get; set; }

        [JsonPropertyName("autor")]
        public string? Autor { get; set; }

        [JsonPropertyName("ano_publicacao")]
        public int? AnoPublicacao { get; set; }

        [JsonPropertyName("editora")]
        public string? Editora { get; set; }

        public void ExibeDetalhesLivros()
        {
            Console.WriteLine($"Livro: {Titulos} - {Autor}, {AnoPublicacao}");
        }
    }
}