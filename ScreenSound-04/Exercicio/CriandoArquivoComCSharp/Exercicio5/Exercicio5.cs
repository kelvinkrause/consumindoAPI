using System.Text.Json;

namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio5
{
    public class Exercicio5
    {
        /*
         * Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, 
         * permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.
         */
        public void Executar()
        {
            string caminhoArquivo = $"F:\\temp\\pessoas.json";
            string stringJson = File.ReadAllText(caminhoArquivo);

            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(stringJson)!;

            Console.Write("Digite a idade da pessoa: ");
            int idadePessoa = int.Parse(Console.ReadLine()!);

            var filtroIdadePessoas = pessoas.Where(pessoa => pessoa.Idade == idadePessoa).ToList();

            filtroIdadePessoas.ForEach(pessoa => pessoa.ExibirInformacoesPessoa());

        }

    }
}