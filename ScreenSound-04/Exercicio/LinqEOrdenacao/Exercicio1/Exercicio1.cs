using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio1.Modelos;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio1
{
    public class Exercicio1
    {
        public async Task Executar()
        {
            List<Filme>? Filmes = await APIFilme();
            Filmes.ForEach(filme => Console.WriteLine($"{filme.Nome}, {filme.AnoLancamento}"));
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
}