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
        Console.WriteLine($"Nome: {Nome} | Preço: {Preco} | QuantidadeEstoque: {QuantidadeEstoque} | DataValidade: {DataValidade}");
    public bool PrecisaReposicao()
    {
        if(QuantidadeEstoque < 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nCOMPRAR {GetType().Name}");
            Console.ResetColor();
            return true;
        }
        return false;
    }
}