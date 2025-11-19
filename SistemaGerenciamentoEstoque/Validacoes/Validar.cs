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
            Console.Write(mensagem);
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
            Console.Write(mensagem);
            int inteiroValidado;
            if(!int.TryParse(Console.ReadLine(), out inteiroValidado) || inteiroValidado <= 0)
            {
                Console.WriteLine(mensagemErro);
                continue;
            }
            return inteiroValidado;
        }
    }
    public static void ValidarIdLista(List<Produto> produtos)
    {
        bool sair = false;
        while (sair != true)
        {
            int idBuscaProduto = ValidarInteiro("\nDigite o Id do produto para buscar: ", "\nPrecisa ser um numero maior que zero!!\n");
            var produto = produtos.Find(x => x.Id == idBuscaProduto);
            if(produto == null)
            {
                Console.WriteLine("\nProduto não encontrado!!");
                continue;
            }
            Console.WriteLine("\nProduto encontrado!");
            Console.WriteLine(produto.ToString());
            sair = true;
        }
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

    public static void RemoverProdutoLista(List<Produto> produtos)
    {
        bool sair = false;
        while (sair != true)
        {
            int idBuscaProduto = ValidarInteiro("\nDigite o Id do produto para buscar: ", "\nPrecisa ser um numero maior que zero!!\n");
            var produto = produtos.Find(x => x.Id == idBuscaProduto);
            if(produto == null)
            {
                Console.WriteLine("\nProduto não encontrado!!");
                continue;
            }
            Console.WriteLine("\nProduto encontrado!");
            Console.WriteLine(produto.ToString());
            produtos.Remove(produto);
            Thread.Sleep(2000);
            Console.WriteLine("\nProduto Removido!");
            sair = true;
        }
    }
}