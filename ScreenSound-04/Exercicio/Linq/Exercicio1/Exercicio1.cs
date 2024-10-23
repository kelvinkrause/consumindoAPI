namespace ScreenSound_04.Exercicio.Linq.Exercicio1
{
    public class Exercicio1
    {
        /*
         * Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.
         */
        public static void Exercicio()
        {
            List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 9, 8, 7};

            var numerosUnicos = numeros.Distinct().ToList();

            numerosUnicos.ForEach(num => Console.WriteLine(num));
        }
    }
}