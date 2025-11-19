namespace SistemaGerenciamentoEstoque.Classes;
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Preco { get; private set; }
    public int QuantidadeEmEstoque { get; private set; }
    public Produto (int id, string nome, string descricao, decimal preco, int quantidadeEmEstoque)
    {
        Id = id;
        SetName(nome);
        SetDescricao(descricao);
        SetPrice(preco);
        SetQuantidadeEmEstoque(quantidadeEmEstoque);
    }
    public void SetName(string nome) => Nome = nome;
    public void SetDescricao(string descricao) => Descricao = descricao;
    public void SetPrice(decimal preco) => Preco = preco;
    public void SetQuantidadeEmEstoque(int quantidadeEmEstoque) => QuantidadeEmEstoque = quantidadeEmEstoque;
    public override string ToString() =>
        $"\nId: {Id} | Nome: {Nome} | Descricao: {Descricao} | Preço: {Preco} | QuantidadeEstoque: {QuantidadeEmEstoque}";
}