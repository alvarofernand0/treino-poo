using MercadoPoggers.Interfaces;
namespace MercadoPoggers.Classes;
public class Eletronico : Produto, IEstoqueCritico
{
    public int MesesGarantia { get; private set; }
    public Eletronico(string nome, decimal preco, int quantidadeEstoque, int mesesGarantia) : base(nome, preco, quantidadeEstoque)
    {
        SetMesesGarantia(mesesGarantia);
    }
    public void SetMesesGarantia(int mesesGarantia) => MesesGarantia = mesesGarantia;
    public override void ExibirDetalhes() =>
        Console.Write($"{GetType().Name} | Nome: {Nome} | Preço: R${Preco} | QuantidadeEstoque: {QuantidadeEstoque}und | TempoGarantia: {MesesGarantia} meses");
    public bool PrecisaReposicao() => QuantidadeEstoque  < 2;
}