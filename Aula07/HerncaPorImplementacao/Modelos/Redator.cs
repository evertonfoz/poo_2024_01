public class Redator : IFreelancer
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public decimal TaxaPorPalavra { get; set; }
    public int PalavrasEscritas { get; set; }
    public decimal CalcularPagamento()
    {
        return TaxaPorPalavra * PalavrasEscritas;
    }
}