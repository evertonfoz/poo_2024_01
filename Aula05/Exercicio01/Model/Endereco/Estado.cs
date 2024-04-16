namespace Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

class Estado {
    public string UF { get; private set; }
    public string Nome { get; private set; }
    public Pais? Pais { get; private set; }

    // ? ! ??
    // public Estado(string uF, string nome)
    // {
    // }
    public Estado(string uF, string nome, Pais? pais = null) 
    {
        UF = uF;
        Nome = nome;
        Pais = pais;
        Pais?.Estados.Add(this);
    }

    public void RegistrarPais(Pais pais) {
        Pais = pais;
        Pais.Estados.Add(this);
    }
}