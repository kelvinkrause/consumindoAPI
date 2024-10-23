using System.Net.NetworkInformation;
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;
public class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();
        todosOsGenerosMusicais.ForEach(generos => Console.WriteLine(generos));
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var todosArtistasPorGenerosMusical = musicas
                                                .Where(musica => musica.Genero!.Contains(genero))
                                                .Select(musica => musica.Artista)
                                                .Distinct()
                                                .ToList();
        todosArtistasPorGenerosMusical.ForEach(musica => Console.WriteLine(musica));
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.ToUpper().Equals(artista.ToUpper())).ToList();
        Console.WriteLine($"Musicas do Artista {artista}");
        musicasDoArtista.ForEach(musica => Console.WriteLine($" - {musica.Nome}"));
    }

}
