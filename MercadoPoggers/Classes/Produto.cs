using MercadoPoggers.Validacoes;
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
    public void SetNome(string nome)
    {
        nome = ValidarString.ValidadorString("\nDigite o nome do produto: ", "\nNão pode ser vazio ou em branco!!");
        Nome = nome;
    }
    public void SetPreco(decimal preco)
    {
        preco = ValidarDecimal.ValidadorDecimal("\nDigite o Preço: ", "\nPrecisa ser um numero maior que zero!!");
        Preco = preco;
    }
    public void SetQuantidadeEstoque(int quantidadeEstoque)
    {
        quantidadeEstoque = ValidarInt.ValidadorInt("\nDigite a quantidade de estoque", "\nPrecisa ser um numero maior que zero!!");
        QuantidadeEstoque = quantidadeEstoque;
    }
    public abstract void ExibirDetalhes();
}