
using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio2.Modelos;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio2
{
    public class Exercicio2 : IExercicios
    {
        public async Task Executar()
        {
            List<Pais> paises = await APIPais();

            paises
                .OrderBy(n => n.Nome)
                .ToList()
                .ForEach(pais => pais.ExibeInformacoesPais());
            
        }

        static async Task<List<Pais>> APIPais()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client
                        .GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
                    return JsonSerializer.Deserialize<List<Pais>>(response)!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
                return new List<Pais>();
            }
        }
    }
}