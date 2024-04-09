namespace Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

class Pais {
    public string Sigla { get; private set; }
    public string Nome { get; private set; }

    private List<Estado> _estados;

    public Pais(string sigla, string nome)
    {
        Sigla = sigla;
        Nome = nome;
        _estados = [];
    }

    public void AdicionarEstado(Estado estado) {
        _estados.Add(new Estado(estado.UF, estado.Nome, this));
    }
}