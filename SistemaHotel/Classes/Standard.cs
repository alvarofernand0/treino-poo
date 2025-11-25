using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class Standard : Quarto
{
    public Standard(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase)
    {
    }
    public override decimal CalcularValorTotalHospedagem(int dias) => ValorDiariaBase * dias;
    public override decimal CalcularTaxaServico()
    {
        decimal calculoTaxaServico = ValorDiariaBase * (5 / 100);
        return calculoTaxaServico;
    }
}