using System.Text.Json;

namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio2
{
    public class Exercicio2
    {
        /*
         * Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, 
         * desserializa essas informações e exibe na tela.
         */

        public static void Executar()
        {
            string fileName = $"F:\\temp\\pessoa-Kelvin.json";

            string stringJson = File.ReadAllText(fileName);

            Console.WriteLine(stringJson);

            Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(stringJson)!;

            pessoa.ExibirInformacoesPessoa();

        }


    }
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }

        public void ExibirInformacoesPessoa()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nEmail: {Email}");
        }

    }
}