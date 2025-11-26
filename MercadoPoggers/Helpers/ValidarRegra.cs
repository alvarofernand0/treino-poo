using MercadoPoggers.Classes;
namespace MercadoPoggers.Helpers;
public static class ValidarRegra
{
    public static bool VerificarLista(List<Produto> produtos)
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Lista Vazia!");
            return false;
        }
        foreach (var produto in produtos)
        {
            produto.ExibirDetalhes();
            Console.WriteLine("");
        }
        return true;
    }

    public static Produto BuscarProdutoPorNome(List<Produto> produtos, string nome)
    {
        var produtoEncontrado = produtos.Find(x => x.Nome.ToLower() == nome.ToLower());
        return produtoEncontrado;
    }
}
