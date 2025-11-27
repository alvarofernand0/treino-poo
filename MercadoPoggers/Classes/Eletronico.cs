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
        Console.WriteLine($"Nome: {Nome} | Preço: {Preco} | QuantidadeEstoque: {QuantidadeEstoque} | TempoGarantia: {MesesGarantia}");

    public bool PrecisaReposicao()
    {
        if(QuantidadeEstoque  < 2)
        {
            Console.WriteLine("\nEstoque não pode ser menor que 2!!");
            return true;
        }
        return false;
    }
}