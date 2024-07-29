namespace HerancaPorExtensao.Incorreto;

public class Desenvolvedor(string nome, decimal salario, string linguagemDeProgramacao)
{

    #region Construtores
    #endregion

    #region Propriedades
    public string Nome { get; set; } = nome;
    public int Id { get; set; }
    public decimal Salario { get; set; } = salario;
    public string LinguagemDeProgramacao { get; set; } = linguagemDeProgramacao;
    #endregion

    #region Métodos
    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está codificando em {LinguagemDeProgramacao}.");
    }
    #endregion
}