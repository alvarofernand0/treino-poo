using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class SuitePresidencial : Quarto
{
    public SuitePresidencial(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase, EStatusQuarto status) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase, status)
    {
    }
    public override decimal CalcularValorTotalHospedagem(int dias)
    {
        decimal calculoDiaria = ValorDiariaBase * dias;
        decimal valorTotalHospedagem = dias > 7 ? calculoDiaria * (10 / 100) : calculoDiaria;
        return valorTotalHospedagem;
    }
}