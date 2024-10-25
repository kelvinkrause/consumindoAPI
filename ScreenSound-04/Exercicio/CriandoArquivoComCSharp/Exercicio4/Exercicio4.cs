using System.Text.Json;

namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio4
{
    public class Exercicio4
    {
        /*
         * Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, 
         * desserializa essas informações em uma lista e exibe na tela
         */

        public static void Executar()
        {
            string caminhoArquivo = $"F:\\temp\\pessoas.json";
            string stringJson = File.ReadAllText(caminhoArquivo);

            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(stringJson)!;

            pessoas.ForEach(pessoa => pessoa.ExibirInformacoesPessoa());
        }
    }
}