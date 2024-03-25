namespace Modelos;
class Moeda {
    public  string Simbolo { get; private set; }
    public  string Nome { get; private set; }
    public string? Pais { get; private set; }

    // public Moeda() {}
    public Moeda(string simbolo , string nome)
    {
        Simbolo = simbolo;
        Nome = nome;

        if (string.IsNullOrWhiteSpace(simbolo)) {
            throw new Exception("Símbolo inválido");
        }
        if (string.IsNullOrWhiteSpace(nome)) {
            throw new Exception("Nome inválido");
        }
    }
   public Moeda(string simbolo, string nome, string pais) : 
        this(simbolo:simbolo, nome:nome)
    {
        Pais = pais;
    }
}

