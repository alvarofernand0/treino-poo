using SistemaHotel.Classes;

namespace SistemaHotel;
public class App
{
    public void IniciarAplicacao()
    {
        var gerenciamentoHotel = new GerenciamentoHotel();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("###### SISTEMA HOTEL ######\n");
            Console.WriteLine("1 - Adicionar Quarto\n");
            Console.WriteLine("2 - Listar Quartos\n");
            Console.WriteLine("3 - Atualizar Quarto\n");
            Console.WriteLine("4 - Remover Quarto\n");
            Console.WriteLine("0 - SAIR\n");
            Console.Write("\nDigite apenas opções válidas! [1, 2, 3, 4 ou 0]: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    gerenciamentoHotel.AdicionarQuarto();
                    break;
            }
        }
    }
}
