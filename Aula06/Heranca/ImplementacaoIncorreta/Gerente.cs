namespace HerancaPorExtensao.Incorreto;

public class Gerente
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public decimal Salario { get; set; }
    public int NumeroDeSubordinados { get; set; }

    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está gerenciando {NumeroDeSubordinados} subordinados.");
    }
}