using ScreenSound_04.Exercicio.Linq.Exercicio3.Modelos;

namespace ScreenSound_04.Exercicio.Linq.Exercicio3
{
    public class Exercicio3
    {
        /*
         * Dada uma lista de produtos com nome e preço, 
         * criar uma consulta LINQ para calcular o preço médio dos produtos.
         */
        
        public static void Exercicio()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto("Detergente", 100),
                new Produto("Esponja", 10),
                new Produto("Esfregão de Aço", 20)
            };

            var precoMedio = produtos.Average(preco => preco.Preco);

            Console.WriteLine(precoMedio);

        }
    }
}