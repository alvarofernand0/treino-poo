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
