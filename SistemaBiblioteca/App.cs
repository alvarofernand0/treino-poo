using SistemaBiblioteca.Classes;
namespace SistemaBiblioteca;
public class App
{
    public void IniciarPrograma()
    {
        var gerenciamentoBiblioteca = new GerenciamentoBiblioteca();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- Sistema Biblioteca v1.0 -----\n");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Adicionar Jornal");
            Console.WriteLine("3 - Adicionar Revista");
            Console.WriteLine("4 - Listar Itens");
            Console.WriteLine("5 - Listar Multas");
            Console.WriteLine("0 - SAIR");
            Console.Write("\nDigite uma das opções [Apenas numeros de 0 a 5]: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    gerenciamentoBiblioteca.AdicionarLivro();
                    break;
                case "2":
                    gerenciamentoBiblioteca.AdicionarJornal();
                    break;
                case "3":
                    gerenciamentoBiblioteca.AdicionarRevista();
                    break;
                case "4":
                    gerenciamentoBiblioteca.ListarItems();
                    break;
                case "5":
                    gerenciamentoBiblioteca.ListarMultas();
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
            Console.Write("\nDigite Algo para retornar ao menu: ");
            Console.ReadKey();
        }
    }
}