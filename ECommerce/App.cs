namespace ECommerce;
public class App
{
    public void IniciarSistema()
    {
        SistemaEcommerce sistemaEcommerce = new SistemaEcommerce();
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("###### Sistema Ecommerce ######\n");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Atualizar Produto");
            Console.WriteLine("4 - Remover Produto");
            Console.WriteLine("5 - Repor Estoque");
            Console.WriteLine("6 - Realizar Venda");
            Console.WriteLine("0 - SAIR\n");
            Console.Write("\nDigite uma das opcoes acima: ");

            string opcao = Console.ReadLine();
            switch(opcao)
            {
                case "1": sistemaEcommerce.AdicionarProduto();
                    break;
                case "2": sistemaEcommerce.ListarProdutos();
                    break;
                case "3": sistemaEcommerce.AtualizarProduto();
                    break;
                case "4": sistemaEcommerce.RemoverProduto();
                    break;
                case "5": sistemaEcommerce.ReporEstoque();
                    break;
                case "6": sistemaEcommerce.RealizarVenda();
                    break;
                case "0":
                    Console.WriteLine("Saindo do Sistema...");
                    Thread.Sleep(2000);        
                    sair = true;
                    Environment.Exit(0);
                    break;
                default: Console.WriteLine("Opcao incorreta!!");
                continue;
            }
            Console.Write("\n\nTecle qualquer tecla para voltar ao menu: ");
            Console.ReadKey();
        }
    }
}
