using SistemaBiblioteca.Enums;
namespace SistemaBiblioteca.Interfaces;
public interface IItemBiblioteca
{
    void AlterarStatus(StatusItemEnum status);
    void RenovarEmprestimo(int diasExtras);
    decimal CalcularMultaAtraso(int diasAtraso);
    int CalcularDiasParaDevolucao();
}