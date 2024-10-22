
using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio3.Modelos;

namespace ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio3
{
    public class Exercicio3 : IExercicios
    {
        public async Task Executar()
        {
            List<Carro> carros = await API();

            carros.ForEach(car => car.ExibeInformacoesCarro());

        }


        static async Task<List<Carro>> API()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client
                        .GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
                    return JsonSerializer.Deserialize<List<Carro>>(response)!;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
                return new List<Carro>();
            }
        }
    }
}