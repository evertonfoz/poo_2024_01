public class Designer : IFreelancer
{
    public string Nome { get; set;  }
    public int Id { get ; set; }
    public decimal TaxaPorHora { get; set; }
public int HorasTrabalhadas { get; set; }

    public decimal CalcularPagamento()
    {
        return TaxaPorHora * HorasTrabalhadas;
    }
}