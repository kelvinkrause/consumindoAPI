namespace ScreenSound_04.Exercicio.Linq.Exercicio4
{
    public class Exercicio4
    {
        /*
         * Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.
         */

        public static void Exercicio()
        {
            List<int> numeros = new List<int> {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};

            var numerosPares = numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            numerosPares.ForEach(numero => Console.WriteLine(numero));
        }
    }
}