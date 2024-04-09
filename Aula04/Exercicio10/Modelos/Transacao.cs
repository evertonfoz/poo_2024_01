using Exercicio10.Modelos;

namespace Modelos;
class Transacao {
    public Taxa Taxa { get; private set; }
    public bool EhValida { get; private set; }

    public Transacao(Taxa taxa, bool ehValida = true)
    {
        Taxa = taxa;
    }

    public void Cancelar() {
        EhValida = false;
    }
}