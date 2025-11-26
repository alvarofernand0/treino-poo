using MercadoPoggers.Helpers;
using MercadoPoggers.Classes;
using MercadoPoggers.Interfaces;
using System.Runtime.CompilerServices;

namespace MercadoPoggers;
public class SistemaMercadoPoggers
{
    private List<Produto> produtos = new List<Produto>();
    public void AdicionarProduto()
    {
        bool sair = false;
        while (sair != true)
        {
            Console.Clear();
            Console.WriteLine("-------- Adicionar Produto --------\n");
            Console.Write("\nDigite 1 para Adicionar um Eletronico e 2 para Alimento: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarEletronico();
                    sair = true;
                    break;
                case "2":
                    AdicionarAlimento();
                    sair = true;
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida! Tente novamente...");
                    Console.ReadKey();
                    continue;
            }
        }
        
        void AdicionarEletronico()
        {
            string nomeEletronico = Input.String("\nDigite o nome do eletronico: ", "\nNão pode ser vazio ou espaço em branco!\n");
            decimal precoEletronico  = Input.Decimal("\nDigite o preço do eletronico: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
            int quantidadeEstoqueEletronico = Input.Inteiro("\nDigite a quantidade em estoque: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
            int mesesGarantia = Input.Inteiro("\nDigite a quantidade de meses de garantia: ", "\nA entrada precisa ser um Numero e maior que zero!\n");
            produtos.Add(new Eletronico(nomeEletronico, precoEletronico, quantidadeEstoqueEletronico, mesesGarantia));
            Console.WriteLine("\nEletronico adicionado!");
        }

        void AdicionarAlimento()
        {
            string nomeAlimento = Input.String("\nDigite o nome do alimento: ", "Não pode ser vazio ou espaço em branco!\n");
            decimal precoAlimento = Input.Decimal("\nDigite o preço do alimento: ", "A entrada precisa ser um Numero e maior que zero!\n");
            int quantidadeEstoqueAlimento = Input.Inteiro("\nDigite a quantidade em estoque: ", "A entrada precisa ser um Numero e maior que zero!\n");
            DateOnly dataValidade;
            while (true)
            {
                dataValidade = Input.Data("\nDigite a data de validade [dd/MM/aaaa]: ", "Data Invalida!\n");
                if (dataValidade > DateOnly.FromDateTime(DateTime.Now))
                    break;
                Console.WriteLine("A data de validade deve ser posterior a data de hoje!");
            }
            
            produtos.Add(new Alimento(nomeAlimento, precoAlimento, quantidadeEstoqueAlimento, dataValidade));
            Console.WriteLine("\nAlimento adicionado!");
        }
    }

    public void ListarProdutos()
    {
        Console.Clear();
        Console.WriteLine("-------- Listar Produtos --------\n");
        if (produtos.Count >= 1)
            foreach (var produto in produtos)
            {
                produto.ExibirDetalhes();
                if(produto is IEstoqueCritico itemCritico && itemCritico.PrecisaReposicao())
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($" | Estoque baixo!! COMPRAR {produto.Nome}");
                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
        else
            Console.WriteLine("Não há produtos para exibir!");
    }

    public void RealizarVenda()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------- Realizar Venda --------\n");
            if(produtos.Count >= 1)
            {
                foreach (var produto in produtos)
                {
                    produto.ExibirDetalhes();
                    Console.WriteLine("");
                }
                string buscarNomeProdutoVenda = Input.String("\nDigite o nome do produto para venda: ", "Não pode ser vazio ou em branco!\n"); 
                var produtoEncontrado = produtos.Find(x => x.Nome.ToLower() == buscarNomeProdutoVenda.ToLower());
                if (produtoEncontrado == null)
                {
                    Console.WriteLine("\nProduto Não encontrado!");
                    DesejaCancelarOperacao();
                }
                else
                {
                    int quantidadeVenda = Input.Inteiro("\nDigite a quantidade do produto que deseja vender: ", "A entrada precisa ser um Numeral e maior que zero!\n");
                    if ( quantidadeVenda > produtoEncontrado.QuantidadeEstoque)
                    {
                        Console.WriteLine("\nErro: Estoque insuficiente para esta venda!");
                        DesejaCancelarOperacao();
                    }
                    else
                    {
                        var estoqueAtualVenda = produtoEncontrado.QuantidadeEstoque;
                        produtoEncontrado.SetQuantidadeEstoque(estoqueAtualVenda - quantidadeVenda);
                        Console.WriteLine("\nVenda concluída!");
                        break;
                    }
                }
            }
            else
                Console.WriteLine("\nNão há produtos para exibir!");
                break;
        }
    }

    public void RenovarEstoque()
    {
        Console.Clear();
        Console.WriteLine("-------- Renovar Estoque --------\n");
        if(produtos.Count >= 1)
        {
            string buscarProdutoRenovarEstoque = Input.String("\nDigite o nome do produto que deseja renovar o estoque: ", "Não pode ser vazio ou em branco!\n");
            var produtoRenovarEstoqueEncontrado = produtos.Find(x => x.Nome.ToLower() == buscarProdutoRenovarEstoque.ToLower());
            if (produtoRenovarEstoqueEncontrado == null)
                Console.WriteLine("\nProduto não encontrado!");
            else
            {
                int adicionarEstoque = Input.Inteiro("\nDigite a quantidade que deseja adicionar ao estoque", "Precisa ser um numeral e maior que zero!\n");
                var estoqueAtualAdicionar = produtoRenovarEstoqueEncontrado.QuantidadeEstoque;
                produtoRenovarEstoqueEncontrado.SetQuantidadeEstoque(estoqueAtualAdicionar + adicionarEstoque);
                Console.WriteLine("\nEstoque atualizado!");
            }
        }
        else
            Console.WriteLine("Não há produtos para exibir!");
    }

    public void AtualizarProduto()
    {
        Console.Clear();
        Console.WriteLine("-------- Atualizar Produto --------\n");
        if(!ValidarRegra.VerificarLista(produtos))
            return;
        string nomeBuscarProduto = Input.String("\n\nDigite o nome de um dos produtos da lista: ", "A entrada não pode ser vazia ou em branco!\n");;
        var produtoParaAtualizar = ValidarRegra.BuscarProdutoPorNome(produtos, nomeBuscarProduto);
        if( produtoParaAtualizar == null)
        {
            Console.WriteLine("\nProduto não encontrado!");
            return;
        }

        if (produtoParaAtualizar is Eletronico eletronico)
        {
            string novoNomeEletronico = Input.String("\nDigite o novo nome do produto: ", "A entrada não pode ser vazia ou em branco!\n");
            decimal novoPrecoEletronico = Input.Decimal("\nDigite o novo preço do eletronico: ", "A entrada precisa ser um Numero e maior que zero!\n");
            int novaGarantiaEletronico = Input.Inteiro("\nDigite a nova quantidade de meses de garantia: ", "A entrada precisa ser um Numero e maior que zero!\n");
            produtoParaAtualizar.SetNome(novoNomeEletronico);
            produtoParaAtualizar.SetPreco(novoPrecoEletronico);
            eletronico.SetMesesGarantia(novaGarantiaEletronico);
        }

        if( produtoParaAtualizar is Alimento alimento)
        {
            string novoNomeAlimento = Input.String("\nDigite o novo nome do alimento: ", "A entrada não pode ser vazia ou em branco!\n");
            decimal novoPrecoAlimento = Input.Decimal("\nDigite o novo preço do alimento: ", "A entrada precisa ser um Numero e maior que zero!\n");
            DateOnly novaDataValidadeAlimento = Input.Data("\nDigite a nova data de validade do alimento: ", "A entrada precisa ser um Numero e maior que zero!\n");
            produtoParaAtualizar.SetNome(novoNomeAlimento);
            produtoParaAtualizar.SetPreco(novoPrecoAlimento);
            alimento.SetDataValidade(novaDataValidadeAlimento);
            Console.WriteLine("Cadastro de Alimento Atualizado!");
        }
    }
    void DesejaCancelarOperacao()
    {
        Console.WriteLine("Deseja cancelar a operação? [S/N]");
        string opcao = Console.ReadLine().ToLower();
        switch (opcao)
        {
            case "s":
                return;
            case "n":
                break;
            default:
                return;
        }
    }
}
