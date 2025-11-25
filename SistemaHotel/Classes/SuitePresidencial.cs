using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class SuitePresidencial : Quarto
{
    public SuitePresidencial(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase)
    {
    }
    public override decimal CalcularValorTotalHospedagem(int dias)
    {
        decimal calculoDiaria = ValorDiariaBase * dias;
        decimal valorTotalHospedagem = dias > 7 ? calculoDiaria * (10 / 100) : calculoDiaria;
        return valorTotalHospedagem;
    }
    public override decimal CalcularTaxaServico()
    {
        decimal calculoTaxaServico = ValorDiariaBase * (25 / 100) + 100;
        return calculoTaxaServico;
    }
}