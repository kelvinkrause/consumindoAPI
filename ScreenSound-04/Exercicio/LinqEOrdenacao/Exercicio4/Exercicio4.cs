
using System.Text.Json;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Modelos
{
    public class Exercicio4 : IExercicios
    {
        public async Task Executar()
        {
            List<Livro> livros = await API();

            livros.ForEach(livro => livro.ExibeDetalhesLivros());

        }

        static async Task<List<Livro>> API()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client
                        .GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
                    return JsonSerializer.Deserialize<List<Livro>>(response)!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new List<Livro>();
            }
        }
    }
}