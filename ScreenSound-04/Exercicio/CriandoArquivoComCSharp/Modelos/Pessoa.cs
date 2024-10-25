namespace ScreenSound_04.Exercicio.CriandoArquivoComCSharp
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }

        public Pessoa(string? nome, int idade, string? email)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Email = email;
            Console.WriteLine($"\nPessoa: {nome} adicionado com sucesso.");
        }

        public void ExibirInformacoesPessoa()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nEmail: {Email}");
        }
    }
}