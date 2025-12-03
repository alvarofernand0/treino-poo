using ECommerce.Enums;
using ECommerce.Helpers;

namespace ECommerce.Classes;
public abstract class Produto
{
    public string Nome { get; private set; }
    
    public decimal Preco { get; private set; }
    
    public DateOnly DataCadastro { get; private set; }
    
    public EStatus Status { get; private set; } = EStatus.Disponivel;
    
    public Produto(string nome, decimal preco, DateOnly dataCadastro)
    {
        SetNome(nome);
        SetPreco(preco);
        SetDataCadastro(dataCadastro);
    }

    public void SetNome(string nome) => Nome = nome;
    
    public void SetPreco(decimal preco) => Preco = preco;
    
    public void SetDataCadastro(DateOnly dataCadastro) => DataCadastro = dataCadastro;
    
    public void SetStatus(EStatus status) => Status = status;
    
    public abstract void ExibirDetalhes();

    public bool VerificarLista(List<Produto> produtos)
    {
        string buscarNome = Input.String("\nDigite O nome do Produto que deseja", "A entrada não pode ser vazia ou em branco!!\n");
        var verificaLista = produtos.Find(x => x.Nome == buscarNome);
        if (verificaLista != null)
            return true;
        return false;
    }
}
