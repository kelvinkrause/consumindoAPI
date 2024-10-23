using System.Text.Json;
using ScreenSound_04.Exercicio.Linq.Exercicio4;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Modelos;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

public class Program
{
    
    //https://hp-api.onrender.com/api/characters/house/gryffindor

    public static async Task Main(string[] args)
    {
        //await new Exercicio1().Executar();
        //await new Exercicio2().Executar();
        //await new Exercicio3().Executar();
        //await new Exercicio4().Executar();
        
        //Exercicio1.Exercicio();
        //await Exercicio2.Exercicio();
        //Exercicio3.Exercicio();
        //Exercicio4.Exercicio();

        await APIMusicas();

    }

    static async Task APIMusicas()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client
                    .GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                
                //Deserialização da API de Musicas em uma Classe 
                var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

                //musicas[0].ExibeInformacoesMusica();

                //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
                //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
                //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Dance/Electronic");
                //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Chris Brown");
                LinqFilter.FiltrarTodasAsMusicasPorAno(musicas, "2010");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
}
