namespace MercadoPoggers.Classes;

public class Eletronico : Produto
{
    public Eletronico(string nome, decimal preco, int quantidadeEstoque) : base(nome, preco, quantidadeEstoque)
    {
    }
    public override void ExibirDetalhes()
    {
        throw new NotImplementedException();
    }
}