using MercadoPoggers.Interfaces;
namespace MercadoPoggers.Classes;
public class Alimento : Produto, IEstoqueCritico
{
    public DateOnly DataValidade { get; private set; }
    public Alimento(string nome, decimal preco, int quantidadeEstoque, DateOnly dataValidade) : base(nome, preco, quantidadeEstoque)
    {
        SetDataValidade(dataValidade);
    }
    public void SetDataValidade(DateOnly dataValidade) => DataValidade = dataValidade;
    public override void ExibirDetalhes() =>
        Console.Write($"{GetType().Name} | Nome: {Nome} | Preço: R${Preco} | QuantidadeEstoque: {QuantidadeEstoque}und | DataValidade: {DataValidade}");
    public bool PrecisaReposicao() => QuantidadeEstoque < 10;
}