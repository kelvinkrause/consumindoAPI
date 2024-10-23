using System.Text.Json;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4;
using ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Modelos;

namespace ScreenSound_04.Exercicio.Linq.Exercicio2
{
    public class Exercicio2
    {
        /*
         * Dada uma lista de livros com título, autor e ano de publicação, 
         * criar uma consulta LINQ para retornar uma lista com os títulos dos livros 
         * publicados após o ano 2000 (1900), ordenados alfabeticamente.
         */

        public static async Task Exercicio()
        {
            List<Livro> livros = await ScreenSound_04.Exercicio.LinqEOrdenacao.Exercicio4.Exercicio4.APILivro();
            var retorno = livros.Where(livro => livro.AnoPublicacao >= 1900).OrderBy(livro => livro.Titulos).ToList();
            retorno.ForEach(livro => livro.ExibeDetalhesLivros());
        }

    }
}