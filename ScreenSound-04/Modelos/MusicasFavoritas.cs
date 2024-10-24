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
        ListMusicasfavoritas.ForEach(musica => Console.WriteLine($"= {musica.Nome} de {musica.Artista}"));
    }

}
