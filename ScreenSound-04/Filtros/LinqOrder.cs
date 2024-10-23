using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

public class LinqOrder
{
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var TodosArtistasOrdenados = musicas
                                        .OrderBy(musica => musica.Artista)
                                        .Select(musica => musica.Artista)
                                        .Distinct()
                                        .ToList();
        TodosArtistasOrdenados.ForEach(musica => Console.WriteLine(musica));
    }
}
