using System.Text.Json;

namespace ScreenSound_04.Modelos;
public class MusicasFavoritas
{
    public string? Nome { get; set; }
    public List<Musica> ListMusicasfavoritas { get; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListMusicasfavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListMusicasfavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Nome}");
        ListMusicasfavoritas.ForEach(musica => Console.WriteLine($" > {musica.Nome} de {musica.Artista}"));
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musica = ListMusicasfavoritas
        });

        string nomeDoArquivo = $"F:\\musicas-favoritas-do-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"Arquivo Json foi criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
    }

}
