namespace MercadoPoggers.Helpers;
public static class Input
{
    public static string String(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            string stringValidada = Console.ReadLine();
            if (string.IsNullOrEmpty(stringValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return stringValidada;
        }
    }
    public static int Inteiro(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            int inteiroValidado;
            if(!int.TryParse(Console.ReadLine(), out inteiroValidado) || inteiroValidado < 1)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return inteiroValidado;
        }
    }
    public static decimal Decimal(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            decimal decimalValidado;
            if(!decimal.TryParse(Console.ReadLine(), out decimalValidado) || decimalValidado < 1)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return decimalValidado;
        }
    }
    public static DateOnly Data(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            DateOnly dataValidada;
            if(!DateOnly.TryParse(Console.ReadLine(), out dataValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return dataValidada;
        }
    }
}