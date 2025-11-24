using SistemaBiblioteca.Enums;
using SistemaBiblioteca.Interfaces;
namespace SistemaBiblioteca.Classes;
public abstract class ItemAcervo : IItemBiblioteca
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int AnoPublicacao { get; private set; }
    public int CodigoIsbn { get; private set; }
    public DateTime DataInicioLocacao { get; private set; }
    public StatusItemEnum Status { get; private set; } = StatusItemEnum.Disponivel;
    public ItemAcervo(string titulo, string autor, int anoPublicacao, int codigoIsbn, DateTime dataInicioLocacao, StatusItemEnum status)
    {
        SetTitulo(titulo);
        SetAutor(autor);
        SetAnoPublicacao(anoPublicacao);
        SetCodigoIsbn(codigoIsbn);
        SetDataInicioLocacao(dataInicioLocacao.Date);
        SetStatus(status);
    }
    public void SetTitulo(string titulo) => Titulo = titulo;
    public void SetAutor(string autor) => Autor = autor;
    public void SetAnoPublicacao(int anoPublicacao) => AnoPublicacao = anoPublicacao;
    public void SetCodigoIsbn(int codigoIsbn) => CodigoIsbn = codigoIsbn;
    public void SetDataInicioLocacao(DateTime dataInicioLocacao) => DataInicioLocacao = dataInicioLocacao.Date;
    public void SetStatus(StatusItemEnum status) => Status = status;
    public void AlterarStatus(StatusItemEnum status)
    {
        SetStatus(status);
        Console.WriteLine($"\nO Novo Status é: {Status}");
    }
    public abstract void RenovarEmprestimo(int diasExtras);
    public abstract decimal CalcularMultaAtraso(int diasAtraso);
    public abstract int CalcularDiasParaDevolucao();
    public override string ToString() =>
    $"\n{GetType().Name} | Titulo: {Titulo} | Autor: {Autor} | AnoPublicacao: {AnoPublicacao} | CodigoISBN: {CodigoIsbn} | Dias para devolução: {CalcularDiasParaDevolucao()} | Data Locacao: {DataInicioLocacao:dd/MM/yyyy} | Status: {Status}";
}