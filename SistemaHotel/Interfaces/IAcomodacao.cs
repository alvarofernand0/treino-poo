namespace SistemaHotel.Interfaces;
public interface IAcomodacao
{
    void RealizarCheckIn();
    void RealizarCheckOut();
    decimal CalcularValorTotalHospedagem(int dias);
    decimal CalcularTaxaServico();
}