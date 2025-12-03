using ECommerce.Enums;
using ECommerce.Interfaces;

namespace ECommerce.Classes;

public class ProdutoDigital : Produto, IProdutoExpirado
{
    public decimal TamanhoMb { get; private set; }
    public DateOnly DataExpiracao { get; private set; }
    public ProdutoDigital(string nome, decimal preco, DateOnly dataCadastro, EStatus status, decimal tamanhoMb, DateOnly dataExpiracao) : base(nome, preco, dataCadastro, status)
    {
        SetTamanhoMb(tamanhoMb);
        SetDataExpiracao(dataExpiracao);
    }

    public void SetTamanhoMb(decimal tamanhoMb) => TamanhoMb = tamanhoMb;
    public void SetDataExpiracao(DateOnly dataExpiracao) => DataExpiracao = dataExpiracao;
    public override void ExibirDetalhes()
    {
        throw new NotImplementedException();
    }

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
