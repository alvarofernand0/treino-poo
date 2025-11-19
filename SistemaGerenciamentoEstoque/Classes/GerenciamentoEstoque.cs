using SistemaGerenciamentoEstoque.Validacoes;
namespace SistemaGerenciamentoEstoque.Classes
{
    public class GerenciamentoEstoque
    {
        List<Produto> produtos = new List<Produto>();
        int idProduto = 0;
        int idIncremento = 0;
        public void CriarProduto()
        {
            Console.Clear();
            Console.WriteLine("---- Criar Produto ----\n");
            string nomeProduto = Validar.ValidarString("\nDigite o Nome do Produto: ", "\nNão pode ser espaço vazio! Tente novamente: ");
            string descricaoProduto = Validar.ValidarString("\nDigite a descricao do produto", "\nNão pode ser espaço em branco ou vazio: ");
            decimal precoProduto = Validar.ValidarDecimal("\nDigite o Preço do produto\n", "\nPrecisa ser um numero maior que zero: ");
            int quantidadeEmEstoque = Validar.ValidarInteiro("\nDigite a quantidade em estoque\n", "\nPrecisa ser um numero maior que zero: ");
            produtos.Add( new Produto(idProduto = ++idIncremento, nomeProduto, descricaoProduto, precoProduto, quantidadeEmEstoque));
        }
        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("---- Listar Produtos ----\n");
            Validar.ValidarListagemLista(produtos);
        }
        public void BuscarProdutoPorId()
        {
            Console.Clear();
            Console.WriteLine("----- Buscar Produto Por Id -----\n");
            int idBuscaProduto = Validar.ValidarInteiro("Digite o Id do produto que deseja buscar", "");
            foreach (var produto in produtos)
            {
                if (produto.Id == idBuscaProduto)
                {
                    Console.WriteLine("Produto encontrado!\n");
                    Console.WriteLine(produtos[idBuscaProduto].ToString());
                }
                else
                    Console.WriteLine("Id Não encontrado");
            }
        }
        public void AtualizarProduto()
        {
            Console.Clear();
            Console.WriteLine("----- Atualizar Produto -----\n");
            Validar.ValidarListagemLista(produtos);
            int idAtualizarProduto = Validar.ValidarInteiro("\nDigite o id do produto que deseja atualizar:", "Precisa ser um numero maior que zero!\n");
            foreach(var produto in produtos)
            {
                if(produto.Id == idAtualizarProduto)
                {
                    string atualizarNomeProduto = Validar.ValidarString("\nDigite o Novo Nome do Produto\n", "Não pode ser vazio ou em branco!\n");
                    string atualizarDescricaoProduto = Validar.ValidarString("\nDigite a nova Descrição\n", "Não pode zer vazio ou em branco!\n");
                    decimal atualizarPrecoProduto = Validar.ValidarDecimal("\nDigite o novo Preço\n", "Precisa ser um numero maior que zero!\n");
                    int atualizarQuantidadeEstoqueProduto = Validar.ValidarInteiro("\nDigite a quantidade em estoque\n", "Precisa ser um numero maior que zero\n");

                    produtos[idAtualizarProduto - 1].SetName(atualizarNomeProduto);
                    produtos[idAtualizarProduto - 1].SetDescricao(atualizarDescricaoProduto);
                    produtos[idAtualizarProduto - 1].SetPrice(atualizarPrecoProduto);
                    produtos[idAtualizarProduto - 1].SetName(atualizarNomeProduto);
                    produtos[idAtualizarProduto - 1].SetQuantidadeEmEstoque(atualizarQuantidadeEstoqueProduto);
                    Console.WriteLine("\nProduto Atualizado!\n");
                    produtos[idAtualizarProduto - 1].ToString();
                }
                else
                    Console.WriteLine("Id não encontrado!\n");  
            }
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