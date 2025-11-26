using System.Net.NetworkInformation;

namespace MercadoPoggers.Validacoes;
public static class ValidarInt
{
    public static int ValidadorInt(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            int inteiroValidado;
            if(!int.TryParse(Console.ReadLine(), out inteiroValidado) || inteiroValidado < 1)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return inteiroValidado;
        }
    }
}
