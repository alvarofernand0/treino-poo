using SistemaHotel.Enums;
using SistemaHotel.Interfaces;
namespace SistemaHotel.Classes;
public class Quarto : IAcomodacao
{
    public int NumeroQuarto { get; private set;}
    public int Andar { get; private set;}
    public int CapacidadePessoas { get; private set;}
    public decimal ValorDiariaBase { get; private set;}
    public EStatusQuarto Status { get; private set;} = EStatusQuarto.Livre;
    public Quarto(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase, EStatusQuarto status)
    {
        SetNumeroQuarto(numeroQuarto);
        SetAndar(andar);
        SetCapacidadePessoas(capacidadePessoas);
        SetValorDiariaBase(valorDiariaBase);
        SetStatus(status);
    }
    public void SetNumeroQuarto(int numeroQuarto) => NumeroQuarto = numeroQuarto;
    public void SetAndar(int andar) => Andar = andar;
    public void SetCapacidadePessoas(int capacidadePessoas) => CapacidadePessoas = capacidadePessoas;
    public void SetValorDiariaBase(decimal valorDiariaBase) => ValorDiariaBase = valorDiariaBase;
    public void SetStatus(EStatusQuarto status) => Status = status; 
    public decimal CalcularTaxaServico()
    {
        throw new NotImplementedException();
    }
    public virtual decimal CalcularValorTotalHospedagem(int dias)
    {
        throw new NotImplementedException();
    }
    public virtual void RealizarCheckIn()
    {
        throw new NotImplementedException();
    }
    public virtual void RealizarCheckOut()
    {
        throw new NotImplementedException();
    }
    public virtual void CalcularTaxaServico(decimal diaria) => Console.WriteLine("");
}