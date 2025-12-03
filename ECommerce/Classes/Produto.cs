using ECommerce.Enums;

namespace ECommerce.Classes;
public abstract class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public DateOnly DataCadastro { get; private set; }
    public EStatus Status { get; private set; } = EStatus.Disponivel;
    public Produto(string nome, decimal preco, DateOnly dataCadastro, EStatus status)
    {
        SetNome(nome);
        SetPreco(preco);
        SetDataCadastro(dataCadastro);
        SetStatus(status);
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetPreco(decimal preco) => Preco = preco;
    public void SetDataCadastro(DateOnly dataCadastro) => DataCadastro = dataCadastro;
    public void SetStatus(EStatus status) => Status = status;
    public abstract void ExibirDetalhes();
}
