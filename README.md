# Desafio: Sistema de Gerenciamento de Estoque (Console)

Você criará um sistema CRUD (Create, Read, Update, Delete) para gerenciar o estoque de produtos de um pequeno armazém. O foco aqui não é fazer uma interface bonita no console, mas sim construir uma arquitetura desacoplada e sólida.

## 1. Entidade Principal: Produto
Sua classe Produto deve conter:

Id (Use Guid para garantir unicidade e facilitar a futura migração para banco de dados).

Nome (string)

Descricao (string)

Preco (decimal)

QuantidadeEmEstoque (int)

## 2. Funcionalidades Requeridas

O menu do seu console deve permitir as seguintes operações:

Criar Produto: Solicita os dados (Nome, Descrição, Preço, Estoque Inicial) e salva.

Listar Produtos: Exibe uma lista de todos os produtos cadastrados (Id, Nome, Preço, Quantidade).

Buscar Produto por ID: Pede um Id e exibe todos os detalhes de um produto.

Atualizar Produto: Pede um Id e permite alterar Nome, Descrição e Preço. (Não permita alterar o estoque por aqui).

Remover Produto: Pede um Id e remove o produto.

Registrar Entrada de Estoque: Pede um Id e uma quantidade. Adiciona a quantidade ao estoque existente.

Registrar Saída de Estoque (Venda): Pede um Id e uma quantidade. Subtrai a quantidade do estoque.


# Exercício 1: Sistema de Gestão de Biblioteca 📚
🎯 Objetivo Desenvolver um sistema para gerenciar empréstimos de itens de uma biblioteca, aplicando POO e organização de pastas.

## 📖 Escopo

Interface IItemBiblioteca Deve conter os métodos:

void AlterarStatus(StatusItemEnum status);

void RenovarEmprestimo(int diasExtras);

decimal CalcularMultaAtraso(int diasAtraso);

int CalcularDiasParaDevolucao();

Enum StatusItemEnum Opções: Disponivel, Emprestado, EmManutencao, Perdido.

Classe Abstrata ItemAcervo

Atributos (privados): Titulo, Autor, AnoPublicacao, CodigoISBN, Status (enum).

Construtor: Define o status padrão como Disponivel.

Deve implementar IItemBiblioteca.

Classes Derivadas Criar Livro, Revista e Jornal.

Regras de Negócio (Sobrescrita):

CalcularDiasParaDevolucao():

Livro: 14 dias.

Revista: 7 dias.

Jornal: 3 dias.

CalcularMultaAtraso(int diasAtraso):

Livro: R$ 1,50 fixo por dia + 10% sobre o total se passar de 10 dias.

Revista: R$ 2,50 fixo por dia de atraso.

Jornal: R$ 5,00 fixo por dia (materiais diários têm multa maior pela urgência).

ToString(): Exibir Título, Autor, Status e o prazo de devolução padrão.



# Exercício 2: Sistema de Reservas de Hotel 🏨
🎯 Objetivo Criar um motor de cálculo para reservas de quartos de hotel com diferentes categorias.

## 📖 Escopo

Interface IAcomodacao Deve conter os métodos:

void RealizarCheckIn();

void RealizarCheckOut();

decimal CalcularValorTotalHospedagem(int dias);

decimal CalcularTaxaServico();

Enum StatusQuartoEnum Opções: Livre, Ocupado, Limpando, Reservado.

Classe Abstrata Quarto

Atributos (privados): NumeroQuarto, Andar, CapacidadePessoas, ValorDiariaBase, Status (enum).

Construtor: Status padrão Livre.

Deve implementar IAcomodacao.

Classes Derivadas Criar Standard, Luxo e SuitePresidencial.

Regras de Negócio (Sobrescrita):

CalcularValorTotalHospedagem(int dias):

Standard: ValorDiariaBase * dias.

Luxo: (ValorDiariaBase * dias) + (10% de taxa se for fim de semana - simule que sempre é).

SuitePresidencial: (ValorDiariaBase * dias). Se ficar mais de 7 dias, recebe 10% de desconto no total.

CalcularTaxaServico() (Custo fixo de limpeza/room service):

Standard: 5% do valor de uma diária.

Luxo: 15% do valor de uma diária.

SuitePresidencial: 25% do valor de uma diária + R$ 100,00 fixos.

ToString(): Exibir Quarto, Tipo, Status e Valor Total Simulado para 3 dias.
