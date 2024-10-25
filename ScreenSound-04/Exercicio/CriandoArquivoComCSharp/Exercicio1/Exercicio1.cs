using System.Text.Json;

namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio1
{
    public class Exercicio1
    {

        /*
         * Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), 
         * serializa essas informações em formato JSON e salva em um arquivo.
         */

        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);
            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine()!;

            Pessoa pessoa = new Pessoa(nome, idade, email);

            string json = JsonSerializer.Serialize(pessoa);

            string caminhoArquivo = $"F:\\temp\\pessoa-{nome}.json";

            File.WriteAllText(caminhoArquivo, json);

            Console.WriteLine("Criado arquivo com sucesso. " + Path.GetFileName(caminhoArquivo));
        }    
    }
}