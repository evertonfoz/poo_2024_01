namespace HerancaPorExtensao.Correto;

public class Gerente : Funcionario
{
    public int NumeroDeSubordinados { get; set; }

    public Gerente(string nome, int id, decimal salario, int numeroDeSubordinados)
        : base(nome, id, salario)
    {
        NumeroDeSubordinados = numeroDeSubordinados;
    }

    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está gerenciando {NumeroDeSubordinados} subordinados.");
    }
}
