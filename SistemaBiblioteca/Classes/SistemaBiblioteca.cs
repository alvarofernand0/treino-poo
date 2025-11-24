using System.Runtime.CompilerServices;
using SistemaBiblioteca.Enums;
namespace SistemaBiblioteca.Classes;
public class GerenciamentoBiblioteca
{
    List<ItemAcervo> itemsAcervo = new List<ItemAcervo>();
    public void AdicionarLivro()
    {
        itemsAcervo.Add(new Livro("As Cronicas de Narnia", "JK Rowling", 2024, 987987, new DateTime(2025, 11, 01), StatusItemEnum.Emprestado));
        Console.WriteLine("Livro adicionado!");
    }
    public void AdicionarRevista()
    {
        itemsAcervo.Add(new Revista("Quatro Rodas", "Auto Esporte", 2020, 987736, new DateTime(2025, 11, 15), StatusItemEnum.Disponivel));
        Console.WriteLine("Revista adicionada!");
    }
    public void AdicionarJornal()
    {
        itemsAcervo.Add(new Jornal("New York Times", "Varios Autores", 2023, 565468, new DateTime(2025, 11, 10), StatusItemEnum.Disponivel));
        Console.WriteLine("Jornal adicionado!");
    }
    public void ListarItems()
    {
        if(itemsAcervo.Count == 0)
        {
            Console.WriteLine("\nLista vazia!!");
        }
        else
        {
            Console.WriteLine("\n----- Listagem de Itens -----");
            foreach(var itemAcervo in itemsAcervo)
            Console.WriteLine(itemAcervo.ToString());
        }
    }
    public void ListarMultas()
    {
        int diasAtraso = 3;
        if(itemsAcervo.Count == 0)
        {
            Console.WriteLine("\nLista vazia!!");
        }
        else
        {
            Console.WriteLine("\n----- Listagem de multas -----");
            foreach (var itemAcervo in itemsAcervo)
            {
                var tipo = itemAcervo is Revista ? "Revista" : itemAcervo is Jornal ? "Jornal" : "Livro";
                Console.WriteLine($"\nTipo: {tipo} | Multa: R${itemAcervo.CalcularMultaAtraso(diasAtraso)}");
            }
        }
    }
}