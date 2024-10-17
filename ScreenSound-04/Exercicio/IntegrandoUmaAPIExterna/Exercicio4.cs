using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Exercicio.IntegrandoUmaAPIExterna
{
    /*
     * Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.
     */

    internal class Exercicio4
    {
        public Exercicio4()
        {
            try
            {
                Produto produto = null;
                produto.QtdProduto();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Algum erro aqi: " + ex.Message);
            }
        }
    }

    internal class Produto
    {
        public void QtdProduto()
        {
            Console.WriteLine("Qtd: ");
        }
    }
}
