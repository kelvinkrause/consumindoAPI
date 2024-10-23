using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;
public class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]  
    public string? Ano { get; set; }  
    
    public void ExibeInformacoesMusica()
    {
        Console.WriteLine($"Artísta: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
