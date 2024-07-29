namespace HerancaPorExtensao.Correto;

public class Desenvolvedor : Funcionario
{
    public string LinguagemDeProgramacao { get; set; }

    public Desenvolvedor(string nome, int id, decimal salario, string linguagemDeProgramacao)
        : base(nome, id, salario)
    {
        LinguagemDeProgramacao = linguagemDeProgramacao;
    }

    public override void Trabalhar()
    {
        //base.Trabalhar();
        Console.WriteLine($"{Nome} está codificando em {LinguagemDeProgramacao}.");
    }
}