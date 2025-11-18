using SistemaGerenciamentoEstoque.Classes;
namespace SistemaGerenciamentoEstoque.Validacoes;
public static class Validar
{
    public static string ValidarString(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.Write(mensagem);
            string stringValidada = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(stringValidada))
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return stringValidada;
        }
    }
    public static decimal ValidarDecimal(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            decimal decimalValidado;
            if(!decimal.TryParse(Console.ReadLine(), out decimalValidado) || decimalValidado <= 0)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return decimalValidado;
        }
    }
    public static int ValidarInteiro(string mensagem, string mensagemErro)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            int inteiroValidado;
            if(!int.TryParse(Console.ReadLine(), out inteiroValidado) || inteiroValidado <= 0)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return inteiroValidado;
        }
    }
    public static List<Produto> PercorrerListaProduto(List<Produto> produtos, int idProduto)
    {
        foreach (var produto in produtos)
        {
            if(produto.Id == idProduto)
                return idProduto;
        }
    }
}