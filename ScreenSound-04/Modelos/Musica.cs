using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;
public class Musica
{

    private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

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
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidades 
    { 
        get
        {
            return tonalidades[Key];
        }
    }
    
    public void ExibeInformacoesMusica()
    {
        Console.WriteLine($"Artísta: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Gênero Musical: {Genero}");
        Console.WriteLine($"Tonalidades ({Key}): {Tonalidades}");
    }
}
