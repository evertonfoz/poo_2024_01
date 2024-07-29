namespace HerancaPorExtensao.Correto;

public class Funcionario(string nome, int id, decimal salario)
{
    public string Nome { get; set; } = nome;
    public int Id { get; set; } = id;
    public decimal Salario { get; set; } = salario;

    public virtual void Trabalhar()
    {
        Console.WriteLine($"{Nome} está trabalhando.");
    }
}
