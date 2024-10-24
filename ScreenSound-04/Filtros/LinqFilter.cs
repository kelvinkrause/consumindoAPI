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
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.ToUpper().Equals(artista.ToUpper())).Distinct().ToList();
        Console.WriteLine($"Musicas do Artista {artista}");
        musicasDoArtista.ForEach(musica => Console.WriteLine($" - {musica.Nome}"));
    }

    public static void FiltrarTodasAsMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasPorAno = musicas
            .Where(musicas => musicas.Ano!.Equals(ano))
            .OrderBy(musicas => musicas.Nome)
            .Select(musicas => $"{musicas.Nome}, {musicas.Artista} {musicas.Ano}")
            .Distinct()
            .ToList();
            
        Console.WriteLine($"Musicas do ano {ano}");
        musicasPorAno.ForEach(musica => Console.WriteLine($" - {musica}"));
    }

    public static void FiltrarMusicasDeUmArtistaComIndice(List<Musica> musicas, string artista)
    {
        Console.WriteLine($"Musicas do Artista {artista}");
        for (int i = 0; i < musicas.Count; i++)
        {
            if (musicas[i].Artista!.Equals(artista))
            {
                Console.WriteLine($" {i} -> {musicas[i].Nome}");
            }
        }
    }

}
