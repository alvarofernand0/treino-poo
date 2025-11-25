using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class Luxo : Quarto
{
    public Luxo(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase)
    {
    }
    public override decimal CalcularValorTotalHospedagem(int dias)
    {
        decimal calculoDiaria = ValorDiariaBase * dias;
        decimal calculoTotalHospedagem = calculoDiaria * (10 / 100);
        return calculoTotalHospedagem;
    }
    public override decimal CalcularTaxaServico()
    {
        decimal calculoTaxaServico = ValorDiariaBase * (15 / 100);
        return calculoTaxaServico;
    }
}