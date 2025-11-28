namespace MercadoPoggers;
public class App
{
    public void IniciarSistema()
    {
        SistemaMercadoPoggers sistemaMercadoPoggers = new SistemaMercadoPoggers();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("######### Sistema Mercado ##########\n");
            Console.WriteLine("1 - Adicionar Produtos");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            Console.WriteLine("5 - ");
            Console.WriteLine("0 - SAIR");
            Console.Write("\nDigite uma da opcoes [1, 2, 3, 4, 5, 0]: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1": sistemaMercadoPoggers.AdicionarProduto();
                    break;
                case "2": sistemaMercadoPoggers.ListarProdutos();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "0":
                    Console.WriteLine("\nSaindo do sistema...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default: Console.WriteLine("\nOpção inválida!");
                    break;
                
            }
            Console.Write("\nTecle algo para voltar ao menu: ");
            Console.ReadKey();
        }
    }
}