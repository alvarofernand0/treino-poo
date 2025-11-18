namespace SistemaGerenciamentoEstoque.Validacoes;
public static class Validar
{
    public static string ValidarString(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            string validaString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(validaString))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return validaString;
        }
    }
}