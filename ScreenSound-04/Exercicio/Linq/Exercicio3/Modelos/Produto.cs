namespace ScreenSound_04.Exercicio.Linq.Exercicio3.Modelos
{
    public class Produto
    {
        public string? Nome { get; set; }
        public Decimal Preco { get; set; }

        public Produto(string? Nome, Decimal preco)
        {
            this.Nome = Nome;
            this.Preco = preco;
        }
    }
}