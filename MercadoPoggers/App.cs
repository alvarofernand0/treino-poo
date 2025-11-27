namespace MercadoPoggers;
public class App
{
    public void IniciarSistema()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("######### Sistema Mercado ##########\n");
            Console.WriteLine("1 - \n");
            Console.WriteLine("2 - \n");
            Console.WriteLine("3 - \n");
            Console.WriteLine("4 - \n");
            Console.WriteLine("5 - \n");
            Console.WriteLine("0 - SAIR");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    break;
                case "2":
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
            }
        }    





        
    }
}