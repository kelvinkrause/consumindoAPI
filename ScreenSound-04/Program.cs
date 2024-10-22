using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio1;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio1.Modelos;
using ScreenSound_04.Musica;

public class Program
{
    
    //https://hp-api.onrender.com/api/characters/house/gryffindor

    public static async Task Main(string[] args)
    {
        await new Exercicio1().Executar();
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
                Console.WriteLine(musicas.Count);

                musicas[0].ExibeInformacoesMusica();


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
            static async Task<List<Filme>> APIFilme()
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    string response = await client
                        .GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                    
                    return JsonSerializer.Deserialize<List<Filme>>(response)!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algum erro ocorreu: " + ex.Message);
                return null!;
            }
        }
}
