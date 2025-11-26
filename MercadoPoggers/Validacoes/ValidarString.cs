namespace MercadoPoggers.Validacoes;
public static class ValidarString
{
    public static string ValidadorString(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            string stringValidada = Console.ReadLine();
            if (string.IsNullOrEmpty(stringValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return stringValidada;
        }
    }
}