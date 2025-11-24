using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class Standard : Quarto
{
    public Standard(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase, EStatusQuarto status) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase, status)
    {
        valorDiariaBase
    }
    public override decimal CalcularValorTotalHospedagem(int dias) => ValorDiariaBase * dias;
}