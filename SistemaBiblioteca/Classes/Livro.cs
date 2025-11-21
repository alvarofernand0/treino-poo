using SistemaBiblioteca.Enums;
namespace SistemaBiblioteca.Classes;
public class Livro : ItemAcervo
{
    public Livro(string titulo, string autor, int anoPublicacao, int codigoIsbn, DateTime dataInicioLocacao, StatusItemEnum status) : base(titulo, autor, anoPublicacao, codigoIsbn, dataInicioLocacao, status)
    {
    }
    public override int CalcularDiasParaDevolucao() => 14;
    public override decimal CalcularMultaAtraso(int diasAtraso)
    {
        if (diasAtraso <= 0)
            return 0m;
        decimal multaBase = diasAtraso * 1.50m;
        if (diasAtraso > 10)
            multaBase += multaBase * 0.10m;
        return multaBase;
    }
    public override void RenovarEmprestimo(int diasExtras)
    {
        throw new NotImplementedException();
    }
}