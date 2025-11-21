using SistemaBiblioteca.Enums;
namespace SistemaBiblioteca.Classes;
public class Revista : ItemAcervo
{
    public Revista(string titulo, string autor, int anoPublicacao, int codigoIsbn, DateTime dataInicioLocacao, StatusItemEnum status) : base(titulo, autor, anoPublicacao, codigoIsbn, dataInicioLocacao, status)
    {
    }
    public override int CalcularDiasParaDevolucao() => 7;
    public override decimal CalcularMultaAtraso(int diasAtraso)
    {
        if (diasAtraso <= 0)
            return 0m;
        decimal multaBase = diasAtraso * 2.50m;
        if (diasAtraso > 10)
            multaBase += multaBase * 0.10m;
        return multaBase;
    }
    public override void RenovarEmprestimo(int diasExtras)
    {
        throw new NotImplementedException();
    }
}