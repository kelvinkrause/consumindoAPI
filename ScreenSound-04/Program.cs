using System.Text.Json;
using ScreenSound_04.Exercicio;
using ScreenSound_04.Exercicio.IntegrandoUmaAPIExterna;
using ScreenSound_04.Musica;

public class Program
{
    
    //https://hp-api.onrender.com/api/characters/house/gryffindor

    public static async Task Main(string[] args)
    {
        await APIMusicas();

        //await new Exercicio1().API();
        //new Exercicio2();
        //new Exercicio3();
        //new Exercicio4();

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
}
