using MercadoPoggers.Validacoes;
using MercadoPoggers.Classes;
namespace MercadoPoggers;
public class SistemaMercadoPoggers
{
    private List<Produto> produtos = new List<Produto>();
    public void AdicionarProduto()
    {
        bool sair = false;
        while (sair != true)
        {
            Console.Clear();
            Console.WriteLine("-------- Adicionar Produto --------\n");
            Console.Write("\nDigite 1 para Adicionar um Eletronico e 2 para Alimento: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    string nomeEletronico = Validar.String("\nDigite o nome do produto: ", "\nNão pode ser vazio ou espaço em branco!\n");
                    decimal precoEletronico  = Validar.Decimal("\nDigite o preço do produto: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                    int quantidadeEstoqueEletronico = Validar.Inteiro("\nDigite a quantidade em estoque: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                    int mesesGarantia = Validar.Inteiro("\nDigite a quantidade de meses de garantia: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
                    produtos.Add(new Eletronico(nomeEletronico, precoEletronico, quantidadeEstoqueEletronico, mesesGarantia));
                    Console.WriteLine("\nEletronico adicionado!");
                    sair = true;
                    break;
                case "2":
                    string nomeAlimento = Validar.String("\nDigite o nome do produto: ", "Não pode ser vazio ou espaço em branco!\n");
                    decimal precoAlimento = Validar.Decimal("\nDigite o preço do produto: ", "A entrada precisa ser um Numero e maior que zero!\n");
                    int quantidadeEstoqueAlimento = Validar.Inteiro("\nDigite a quantidade em estoque: ", "A entrada precisa ser um Numero e maior que zero!\n");
                    DateOnly dataValidade = Validar.Data("\nDigite a data de validade [dd/MM/aaaa]: ", "Data Invalida!\n");
                    produtos.Add(new Alimento(nomeAlimento, precoAlimento, quantidadeEstoqueAlimento, dataValidade));
                    Console.WriteLine("\nAlimento adicionado!");
                    sair = true;
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida! Tente novamente...");
                    Console.ReadKey();
                    continue;
            }
        }
    }
    public void ListarProdutos()
    {
        Console.Clear();
        Console.WriteLine("-------- Listar Produtos --------\n");
        if (produtos.Count >= 1)
            foreach (var produto in produtos)
            {
                produto.ExibirDetalhes();
                produto
            }
        Console.WriteLine("Não há produtos para exibir!\n");
    }
}