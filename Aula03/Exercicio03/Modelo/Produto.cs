namespace Cadastros.Modelo;

public class Produto {
    private string _nome;
    public string Nome
    {
        get { return _nome.ToUpper(); }
    }

    public float Preco { get; private set; }

    public void RegistrarNome(string nome) {
        if (string.IsNullOrEmpty(nome)) {
//        if (nome.Trim().Length == 0) {
            throw new Exception("Nome precisa ter algum valor" );
        }
        _nome = nome;
    }
    
}
