namespace SistemaHotel.Classes;
public class GerenciamentoHotel
{
    List<Quarto> quartos = new List<Quarto>();
    public void AdicionarQuarto()
    {
        quartos.Add(new Standard(305, 3, 2, 149.99m));
        quartos.Add(new Luxo(201, 2, 3, 229.99m));
        quartos.Add(new SuitePresidencial(703, 4, 4, 359.99m));
        Console.WriteLine("\nQuartos adicionados com sucesso!");
    }
}