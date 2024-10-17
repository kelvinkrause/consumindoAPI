using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Exercicio.IntegrandoUmaAPIExterna
{
    internal class Exercicio2
    {
        /*
         * Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. 
         * Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
         */

        public Exercicio2()
        {
            Divisao();
        }

        void Divisao()
        {
            try
            {
                Console.Write("Digite um numero dividendo: ");
                Decimal valor1 = decimal.Parse(Console.ReadLine()!);
                Console.Write("Digite um numero divisor: ");
                Decimal valor2 = decimal.Parse(Console.ReadLine()!);



                Console.WriteLine($"A divisão de {valor1} / {valor2} é igual a {valor1 / valor2}.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Houve algum erro: {ex.Message}");
            }
        }
    }
}
