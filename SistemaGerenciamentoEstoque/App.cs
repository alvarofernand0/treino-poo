using SistemaGerenciamentoEstoque.Classes;
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
            Console.Write("\nDigite uma das opções [Apenas numeros de 0 a 7]: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    gerenciamentoEstoque.CriarProduto();
                    Bipar();
                    break;
                case "2":
                    gerenciamentoEstoque.ListarProdutos();
                    AguardarTeclaParaVoltarAoMenu();
                    break;
                case "3":
                    gerenciamentoEstoque.BuscarProdutoPorId();
                    AguardarTeclaParaVoltarAoMenu();
                    break;
                case "4":
                    gerenciamentoEstoque.AtualizarProduto();
                    Bipar();
                    break;
                case "5":
                    gerenciamentoEstoque.RemoverProduto();
                    Bipar();
                    break;
                case "6":
                    gerenciamentoEstoque.RegistrarEntradaEstoque();
                    Bipar();
                    break;
                case "7":
                    gerenciamentoEstoque.RegistrarSaidaEstoque();
                    Bipar();
                    break;
                case "0":
                    Console.WriteLine("Saindo do Sistema...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida!");
                    AguardarTeclaParaVoltarAoMenu();
                    break;
            }
        }
    }
    private void AguardarTeclaParaVoltarAoMenu()
    {
        Console.Write("\nPressione qualquer tecla para retornar ao menu: ");
        Console.ReadKey();
    }
    private void Bipar()
    {
        Console.Beep(2000,1000);
        Thread.Sleep(1000);
    }
}