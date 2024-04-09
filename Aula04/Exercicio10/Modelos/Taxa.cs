using Modelos;

namespace Exercicio10.Modelos;
class Taxa
{
    public Operacao Operacao { get; private set; }
    public double Valor { get; private set; }
    public DateTime DataEHoraAtualizacao { get; private set; }

    public Taxa(Operacao operacao, double valor, DateTime dataEHoraAtualizacao)
    {
        Operacao = operacao;
        Valor = valor;
        DataEHoraAtualizacao = dataEHoraAtualizacao;   
    }
}
