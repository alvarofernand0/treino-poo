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
    public static string ValidarIdLista(List<Produto> produtos, int idProduto, string mensagemErro)
    {
        foreach (var produto in produtos)
        {
            if (produto.Id == idProduto)
                return idProduto.ToString();
        }
        return mensagemErro;
    }
    public static void ValidarListagemLista(List<Produto> produtos)
    {
        if(produtos.Count >= 1)
        {
            foreach (var produto in produtos)
                Console.WriteLine(produto.ToString()+"\n");
        }
        else
            Console.WriteLine("Não há produtos na Lista!!\n");
    }
}