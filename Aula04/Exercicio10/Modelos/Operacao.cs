namespace Modelos;
class Operacao {
    public Moeda MoedaDeCompra { get; private set; }
    public Moeda MoedaDeVenda { get; private set; }

    public Operacao(Moeda moedaCompra, Moeda moedaVenda)
    {
        MoedaDeCompra = moedaCompra;
        MoedaDeVenda = moedaVenda;
    }
}