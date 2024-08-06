public interface IFreelancer
{
    string Nome { get; set; }
    int Id { get; set; }
    decimal CalcularPagamento();
}