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
            string nomeProduto = Validar.ValidarString("\nDigite o Nome do Produto: ", "\nNão pode ser espaço vazio! Tente novamente!");
            string descricaoProduto = Validar.ValidarString("\nDigite a descricao do produto: ", "\nNão pode ser espaço em branco ou vazio!");
            decimal precoProduto = Validar.ValidarDecimal("\nDigite o Preço do produto: ", "\nPrecisa ser um numero maior que zero!");
            int quantidadeEmEstoque = Validar.ValidarInteiro("\nDigite a quantidade em estoque: ", "\nPrecisa ser um numero maior que zero!");
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
            Validar.ValidarIdLista(produtos);
        }
        public void AtualizarProduto()
        {
            Console.Clear();
            Console.WriteLine("----- Atualizar Produto -----\n");
            Validar.ValidarListagemLista(produtos);
            int idAtualizarProduto = Validar.ValidarInteiro("\nDigite o id do produto que deseja atualizar: ", "\nPrecisa ser um numero maior que zero!\n");
            foreach(var produto in produtos)
            {
                if(produto.Id == idAtualizarProduto)
                {
                    string atualizarNomeProduto = Validar.ValidarString("\nDigite o Novo Nome do Produto: ", "\nNão pode ser vazio ou em branco! \n");
                    string atualizarDescricaoProduto = Validar.ValidarString("\nDigite a nova Descrição: ", "\nNão pode zer vazio ou em branco! \n");
                    decimal atualizarPrecoProduto = Validar.ValidarDecimal("\nDigite o novo Preço: ", "\nPrecisa ser um numero maior que zero! \n");
                    produtos[idAtualizarProduto - 1].SetName(atualizarNomeProduto);
                    produtos[idAtualizarProduto - 1].SetDescricao(atualizarDescricaoProduto);
                    produtos[idAtualizarProduto - 1].SetPrice(atualizarPrecoProduto);
                    produtos[idAtualizarProduto - 1].SetName(atualizarNomeProduto);
                    Console.WriteLine("\nProduto Atualizado!\n");
                    produtos[idAtualizarProduto - 1].ToString();
                }
                else
                    Console.WriteLine("Id não encontrado!\n");  
            }
        }
        public void RemoverProduto()
        {
            Console.Clear();
            Console.WriteLine("----- Remover Produto -----\n");
            if (produtos.Count >= 1)
            {
                Validar.ValidarListagemLista(produtos);
                Validar.RemoverProdutoLista(produtos);
            }
            else
                Validar.ValidarListagemLista(produtos);
        }
        public void RegistrarEntradaEstoque()
        {
            Console.Clear();
            Console.WriteLine("----- Registrar Entrada de Estoque -----\n");
            if(produtos.Count >= 1)
            {
                Validar.ValidarListagemLista(produtos);
                bool sair = false;
                while (sair != true)
                {
                    int idEntradaEstoque = Validar.ValidarInteiro("\nDigite o id do produto que deseja adicionar estoque: ", "\nPrecisa ser maior que zero!!\n");
                    var produto = produtos.Find(x => x.Id == idEntradaEstoque);
                    if (produto == null)
                    {
                        Console.WriteLine("Produto não encontrado!!");
                        continue;
                    }
                    int novaQuantidadeEstoque = Validar.ValidarInteiro("\nDigite a quantidade que deseja adicionar ao estoque: ", "\nPrecisa ser maior que zero!!\n");
                    int quantidadeEstoqueAtual = produto.QuantidadeEmEstoque;
                    produto.SetQuantidadeEmEstoque(quantidadeEstoqueAtual + novaQuantidadeEstoque);
                    Console.WriteLine("\nEstoque Atualizado!!\n");
                    Console.WriteLine(produto.ToString());
                    sair = true;
                }    
            }
            else
                Validar.ValidarListagemLista(produtos);
        }
        public void RegistrarSaidaEstoque()
        {
            Console.Clear();
            Console.WriteLine("----- Registrar Saida de Estoque -----\n");
            if (produtos.Count >= 1)
            {
                Validar.ValidarListagemLista(produtos);
                bool sair = false;
                while (sair != true)
                {
                    int idSaidaEstoque = Validar.ValidarInteiro("\nDigite o id do produto que deseja retirar estoque: ", "\nPrecisa ser maior que zero!!\n");
                    var produto = produtos.Find(x => x.Id == idSaidaEstoque);
                    if (produto == null)
                    {
                        Console.WriteLine("Produto não encontrado!!");
                        continue;
                    }
                    int subtrairQuantidadeEstoque = Validar.ValidarInteiro("\nDigite a quantidade para subtrair ao estoque: ", "\nPrecisa ser maior que zero!!\n");
                    int quantidadeEstoqueAtual = produto.QuantidadeEmEstoque;
                    produto.SetQuantidadeEmEstoque(quantidadeEstoqueAtual - subtrairQuantidadeEstoque);
                    Console.WriteLine("\nEstoque Atualizado!!\n");
                    Console.WriteLine(produto.ToString());
                    sair = true;
                }
            }
            else
                Validar.ValidarListagemLista(produtos);
        }
    }
}