using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Modelos;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4
{
    public class Exercicio4 : IExercicios
    {
        public async Task Executar()
        {
            List<Livro> livros = await APILivro();

            livros.ForEach(livro => livro.ExibeDetalhesLivros());

        }

        public static async Task<List<Livro>> APILivro()
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