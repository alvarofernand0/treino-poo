namespace MercadoPoggers.Classes;
public abstract class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEstoque { get; private set; }
    public Produto(string nome, decimal preco, int quantidadeEstoque)
    {
        SetNome(nome);
        SetPreco(preco);
        SetQuantidadeEstoque(quantidadeEstoque);
    }
    public void SetNome(string nome) => Nome = nome;
    public void SetPreco(decimal preco) => Preco = preco;
    public void SetQuantidadeEstoque(int quantidadeEstoque) => QuantidadeEstoque = quantidadeEstoque;
    public abstract void ExibirDetalhes();
}