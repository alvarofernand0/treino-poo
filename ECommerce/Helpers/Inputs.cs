using ECommerce.Enums;

namespace ECommerce.Helpers;
public static class Input
{
    public static string String(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            string stringValidada = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(stringValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return stringValidada;
        }
    }

    public static decimal Decimal(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            decimal decimalValidado;
            if(!decimal.TryParse(Console.ReadLine(), out decimalValidado) || decimalValidado < 1)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return decimalValidado;
        }
    }

    public static int Inteiro(string mensagem, string mensagemErro)
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

    public static DateOnly Data(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            DateOnly dataValidada;
            if(!DateOnly.TryParse(Console.ReadLine(), out dataValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return dataValidada;
        }
    }

    public static EStatus Status(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            EStatus statusValidado;
            if(!EStatus.TryParse(Console.ReadLine(), out statusValidado))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return statusValidado;
        }
    }
}
