using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Exercicio.IntegrandoUmaAPIExterna
{
    internal class Exercicio3
    {
        /*
         * Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
         */

        public Exercicio3()
        {
            try
            {
                List<string> list = new List<string>
                {
                    "A",
                    "B",
                    "C"
                };

                Console.WriteLine(list[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aconteceu algum problema: " + ex.Message);
            }


        }


    }
}
