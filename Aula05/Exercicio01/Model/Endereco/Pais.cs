namespace Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

class Pais(string sigla, string nome)
{
    public string Sigla { get; private set; } = sigla;
    public string Nome { get; private set; } = nome;

    public List<Estado> Estados { get; private set; } = [];

    public void RegistrarEstado(Estado estado) {
        estado.RegistrarPais(this);
    }
}