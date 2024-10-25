using System.ComponentModel.Design;
using System.Text.Json;

namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp.Exercicio3
{
    public class Exercicio3
    {
        /*
         * Criar um programa que permite ao usuário inserir informações de várias pessoas, 
         * armazena essas informações em uma lista, 
         * serializa a lista em formato JSON e salva em um arquivo.
         */

        private List<Pessoa> pessoas = new List<Pessoa>();

        public void Executar()
        {
            Console.WriteLine("--------------- Lista de Pessoas ---------------");
            Menu();
        }

        void Menu()
        {
            Console.WriteLine("Digite 1 para adicionar uma Pessoa a lista");
            Console.WriteLine("Digite 2 para exibir lista de Pessoas");
            Console.WriteLine("Digite 3 para gerar o arquivo Json das Pessoas");
            Console.WriteLine("Digite 0 para sair\n");
            Opcoes();
        }

        void Opcoes()
        {
            try
            {
                Console.Write("Escolha uma opcao: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindoo...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 1:
                        AdicionarPessoa();
                        break;
                    case 2:
                        ExibirPessoaDaLista();
                        break;
                    case 3:
                        GerarArquivoJsonPessoas();
                        break;
                    default:
                        Console.WriteLine("Opções inválida.");
                        Thread.Sleep(2000);
                        Menu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write("\nOcorreu algum erro: " + ex.Message);
                RetornaMenu();
            }
        }

        void AdicionarPessoa()
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o e-mail da pessoa: ");
            string email = Console.ReadLine()!;

            pessoas.Add(new Pessoa(nome, idade, email));

            RetornaMenu();
        }

        void ExibirPessoaDaLista()
        {
            Console.Clear();
            Console.WriteLine("---------- Lista de Pessoas ----------");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Ideade: {pessoa.Idade}, E-mail: {pessoa.Email}");
            }
            RetornaMenu();
        }

        void GerarArquivoJsonPessoas()
        {
            string json = JsonSerializer.Serialize(pessoas);
            string caminhoArquivo = $"F:\\temp\\pessoas.json";

            File.WriteAllText(caminhoArquivo, json);

            string mensagem = File.Exists(caminhoArquivo) ? $"\nArquivo Gerado com Sucesso. \n" + Path.GetFullPath(caminhoArquivo) : "ERRO: Arquivo não gerado.";

            Console.WriteLine(mensagem);

            RetornaMenu();
        }

        void RetornaMenu()
        {
            Console.Write("\nTecle enter para retornar ao menu");
            Console.ReadKey(true);
            Console.Clear();
            Menu();
        }
    }
}