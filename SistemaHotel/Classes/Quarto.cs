using SistemaHotel.Enums;
using SistemaHotel.Interfaces;
namespace SistemaHotel.Classes;
public abstract class Quarto : IAcomodacao
{
    public int NumeroQuarto { get; private set;}
    public int Andar { get; private set;}
    public int CapacidadePessoas { get; private set;}
    public decimal ValorDiariaBase { get; private set;}
    public EStatusQuarto Status { get; private set;} = EStatusQuarto.Livre;
    public Quarto(int numeroQuarto, int andar, int capacidadePessoas, decimal valorDiariaBase)
    {
        SetNumeroQuarto(numeroQuarto);
        SetAndar(andar);
        SetCapacidadePessoas(capacidadePessoas);
        SetValorDiariaBase(valorDiariaBase);
    }
    public void SetNumeroQuarto(int numeroQuarto) => NumeroQuarto = numeroQuarto;
    public void SetAndar(int andar) => Andar = andar;
    public void SetCapacidadePessoas(int capacidadePessoas) => CapacidadePessoas = capacidadePessoas;
    public void SetValorDiariaBase(decimal valorDiariaBase) => ValorDiariaBase = valorDiariaBase;
    public void SetStatus(EStatusQuarto status) => Status = status;
    public abstract decimal CalcularTaxaServico();
    public abstract decimal CalcularValorTotalHospedagem(int dias);
    public void RealizarCheckIn()
    {
        SetStatus(EStatusQuarto.Ocupado);
        Console.WriteLine($"\nCheckIn do quarto {GetType().Name} Realizado!");
    }
    public void RealizarCheckOut()
    {
        SetStatus(EStatusQuarto.Livre);
        Console.WriteLine($"\nCheckOut do quarto {GetType().Name} Realizado!");
    }
}