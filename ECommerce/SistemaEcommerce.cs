using ECommerce.Classes;
using ECommerce.Enums;
using ECommerce.Helpers;
using Microsoft.VisualBasic;

namespace ECommerce;
public class SistemaEcommerce
{
    private List<Produto> produtos = [];

    public void AdicionarProduto()
    {
        bool sair = false;
        while(!sair)
        {
            Console.Clear();
            Console.WriteLine("---------- Adicionar Produto ----------\n");
            Console.WriteLine("1 - Produto Digital");
            Console.WriteLine("2 - Produto Fisico");
            Console.Write("\nDigite uma das opções: ");
            string tipoProduto = Console.ReadLine();
            switch (tipoProduto)
            {
                case "1": ProdutoDigital();
                    break;
                case "2": ProdutoFisico();
                    break;
                default: Console.WriteLine("Precisa ser uma das opções [1 ou 2]");
                    continue;
            }
        }

        void ProdutoDigital()
        {
            string nomeProdutoDigital = Input.String("\nDigite o nome do Produto Digital ", "A entrada não pode ser vazia ou em branco!!\n");
            decimal precoProdutoDigital = Input.Decimal("\nDigite o preco do Produto Digital ", "A entrada precisa ser um número e Maior que zero\n");
            DateOnly dataCadastroProdutoDigital = Input.Data("\nDigite a data de cadastro ", "A entrada precisa ser uma data válida [dd,MM,aaaa ou dd/MM/aaaa]\n");
            decimal tamanhoMbProdutoDigital = Input.Decimal("\nDigite o tamanho em Mb do produto Digital ", "A entrada precisa ser um numero e maior que zero\n");
            DateOnly dataExpiracaoProdutoDigital = Input.Data("\nDigite a data de expiracao do produto Digital ", "A entrada precisa ser uma data válida [dd,MM,aaaa ou dd/MM/aaaa]\n");
            produtos.Add(new ProdutoDigital(nomeProdutoDigital, precoProdutoDigital, dataCadastroProdutoDigital, tamanhoMbProdutoDigital, dataExpiracaoProdutoDigital));
            Console.WriteLine("\nProduto adicionado com sucesso!!");
        }

        void ProdutoFisico()
        {
            string nomeProdutoFisico = Input.String("\nDigite o nome do Produto Físico ", "A entrada não pode ser vazia ou em branco!!\n");
            decimal precoProdutoFisico = Input.Decimal("\nDigite o preco do Produto Físico ", "A entrada precisa ser um número e Maior que zero\n");
            DateOnly dataCadastroProdutoFisico = Input.Data("\nDigite a data de cadastro ", "A entrada precisa ser uma data válida [dd,MM,aaaa ou dd/MM/aaaa]\n");
            decimal freteProdutoFisico = Input.Decimal("\nDigite o o valor do Frete do produto Físico ", "A entrada precisa ser um número e Maior que zero\n");
            int estoqueProdutoFisico = Input.Inteiro("\nDigite a quantidade em estoque do produto físico", "A entrada precisa ser um número e Maior que zero\n");
            produtos.Add(new ProdutoFisico(nomeProdutoFisico, precoProdutoFisico, dataCadastroProdutoFisico, freteProdutoFisico, estoqueProdutoFisico));
            Console.WriteLine("\nProduto adicionado com sucesso!!");
        }
    }

    public void ListarProdutos()
    {
        Console.Clear();
        Console.WriteLine("-------- Listar Produtos --------\n");
        
        
    }

    public void AtualizarProduto()
    {
        
    }

    public void RemoverProduto()
    {
        
    }

    public void ReporEstoque()
    {
        
    }

    public void RealizarVenda()
    {
        
    }
}
