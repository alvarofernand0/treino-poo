using ECommerce.Enums;
using ECommerce.Interfaces;

namespace ECommerce.Classes;

public class ProdutoDigital : Produto, IProdutoExpirado
{
    public decimal TamanhoMb { get; private set; }
    public DateOnly DataExpiracao { get; private set; }
    public ProdutoDigital(string nome, decimal preco, DateOnly dataCadastro, decimal tamanhoMb, DateOnly dataExpiracao) : base(nome, preco, dataCadastro)
    {
        SetTamanhoMb(tamanhoMb);
        SetDataExpiracao(dataExpiracao);
    }

    public void SetTamanhoMb(decimal tamanhoMb) => TamanhoMb = tamanhoMb;
    public void SetDataExpiracao(DateOnly dataExpiracao)
    {
        if(dataExpiracao <= DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("Data de expiração precisa ser posterior a data atual");
            return;
        }
        DataExpiracao = dataExpiracao;
    }
    public override void ExibirDetalhes() =>
        Console.WriteLine($"{GetType().Name} | Nome: {Nome} | Preco: {Preco} | DataCadastro: {DataCadastro} | Status: {Status} | Tamanho {TamanhoMb}Mbs | DataExpiracao {DataExpiracao}");

    public bool ProdutoExpirou()
    {
        if (DataExpiracao < DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine($"{Nome} Expirado!! ");
            return true;
        }
        return false;
    }
}
