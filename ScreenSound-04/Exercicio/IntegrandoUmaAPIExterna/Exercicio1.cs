
namespace ScreenSound_04.Exercicio.IntegrandoUmaAPIExterna;
public class Exercicio1
{
    public async Task API()
    {
        /*
         * Escrever um programa que faça uma requisição para a API de games CheapShark 
         * e mostre na tela a lista de promoções cadastrada na ferramenta 
         * (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).
         */


        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }
}

