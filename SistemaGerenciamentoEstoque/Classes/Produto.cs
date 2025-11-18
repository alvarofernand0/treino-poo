namespace SistemaGerenciamentoEstoque.Classes;
public class Produto
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto (int id, string nome, string descricao, decimal preco, int quantidadeEmEstoque)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
}