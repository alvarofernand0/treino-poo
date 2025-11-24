using SistemaHotel.Enums;
namespace SistemaHotel.Classes;
public class Luxo : Quarto
{
    public Luxo(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase, EStatusQuarto status) : base(numeroQuarto, andar, capacidadePessoas, valorDiariaBase, status)
    {
    }
    public override decimal CalcularValorTotalHospedagem(int dias)
    {
        decimal calculoDiaria = ValorDiariaBase * dias;
        decimal calculoTotalHospedagem = calculoDiaria * (10 / 100);
        return calculoTotalHospedagem;
    }
}