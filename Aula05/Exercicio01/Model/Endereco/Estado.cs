namespace Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

class Estado {
    public string UF { get; private set; }
    public string Nome { get; private set; }
    private Pais? Pais;

    public Estado(string uf, string nome)
    {
        UF = uf;
        Nome = nome;
    }

    public Estado(string uf, string nome, Pais pais) : this(uf, nome) {
        Pais = pais;
    }
}