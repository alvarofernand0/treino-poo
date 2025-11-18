using SistemaGerenciamentoEstoque.Validacoes;
namespace SistemaGerenciamentoEstoque.Classes
{
    public class GerenciamentoEstoque
    {
        public void CriarProduto()
        {
            Console.WriteLine("---- CriarProduto ----\n");
            
            string NomeProduto = Validar.ValidarString("\nDigite o Nome do Produto: ", "\nNão pode ser espaço vazio! Tente novamente: ");
        }
        public void ListarProdutos()
        {
            
        }
        public void BuscarProdutoPorId()
        {
            
        }
        public void AtualizarProduto()
        {
            
        }
        public void RemoverProduto()
        {
            
        }
        public void RegistrarEntradaEstoque()
        {
            
        }
        public void RegistrarSaidaEstoque()
        {
            
        }
    }
}