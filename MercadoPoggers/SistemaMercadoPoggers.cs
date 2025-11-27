using MercadoPoggers.Validacoes;
using MercadoPoggers.Classes;
namespace MercadoPoggers;
public class SistemaMercadoPoggers
{
    private List<Produto> produtos = new List<Produto>();
    public void AdicionarProduto()
    {
        Console.Clear();
        Console.WriteLine("-------- Adicionar Produto --------\n");
        Console.Write("\nDigite 1 para Adicionar um Eletronico e 2 para Alimento: ");
        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":   string nome = Validar.String("\nDigite o nome do produto: ", "\nNão pode ser vazio ou espaço em branco!\n");
                        decimal preco  = Validar.Decimal("\nDigite o preço do produto: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                        int quantidadeEstoque = Validar.Inteiro("\nDigite a quantidade em estoque: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                        int mesesGarantia = Validar.Inteiro("\nDigite a quantidade de meses de garantia: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                break;
            case "2":
                break;
            default:
                break;
        }
    }
}