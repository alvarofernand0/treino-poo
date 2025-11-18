using SistemaGerenciamentoEstoque;
using SistemaGerenciamentoEstoque.Classes;
using SistemaGerenciamentoEstoque.Validacoes;

namespace SistemaGerenciamentoEstoque;
public class App
{
    public void IniciarPrograma()
    {
        var gerenciamentoEstoque = new GerenciamentoEstoque();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- Sistema de controle de Estoque v1.0 -----\n");
            Console.WriteLine("1 - Criar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Buscar Produto por Id");
            Console.WriteLine("4 - Atualizar Produto");
            Console.WriteLine("5 - Remover Produto");
            Console.WriteLine("6 - Registrar Entrada de Estoque");
            Console.WriteLine("7 - Registrar Saída de Estoque");
            Console.WriteLine("0 - SAIR");
            Console.Write("\n\nDigite uma das opções [Apenas numeros de 0 a 7]: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    gerenciamentoEstoque.CriarProduto();
                    break;
                case "2":
                    gerenciamentoEstoque.ListarProdutos();
                    break;
                case "3":
                    gerenciamentoEstoque.BuscarProdutoPorId();
                    break;
                case "4":
                    gerenciamentoEstoque.AtualizarProduto();
                    break;
                case "5":
                    gerenciamentoEstoque.RemoverProduto();
                    break;
                case "6":
                    gerenciamentoEstoque.RegistrarEntradaEstoque();
                    break;
                case "7":
                    gerenciamentoEstoque.RegistrarSaidaEstoque();
                    break;
                case "0":
                    Console.WriteLine("Saindo do Sistema...");
                    Thread.Sleep(2500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
            Console.WriteLine("Digite Algo para retornar ao menu: ");
            Console.ReadKey();
        }
    }
}
