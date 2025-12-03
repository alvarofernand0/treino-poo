using ECommerce.Enums;
using ECommerce.Interfaces;

namespace ECommerce.Classes;
public class ProdutoFisico : Produto, IEstoqueBaixo
{
    public decimal Frete { get; private set; }
    public int Estoque { get; private set; }
    public ProdutoFisico(string nome, decimal preco, DateOnly dataCadastro, decimal frete, int estoque) : base(nome, preco, dataCadastro)
    {
        SetFrete(frete);
        SetEstoque(estoque);
    }
    
    void SetFrete(decimal frete) => Frete = frete;
    void SetEstoque(int estoque) => Estoque = estoque;
    public override void ExibirDetalhes() =>
        Console.WriteLine($"{GetType().Name} | Nome: {Nome} | Preco: R${Preco:f2} | DataCadastro: {DataCadastro} | Status: {Status} | Frete: R${Frete} | Estoque: {Estoque}");

    public bool EstoqueCritico()
    {
        if(Estoque < 10)
        {
            Console.WriteLine($" | Estoque baixo!! Comprar {Nome}");
            return true;
        }
        return false;
    }
}
