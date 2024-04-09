// See https://aka.ms/new-console-template for more information
using Exercicio10.Modelos;
using Modelos;

// var moeda = new Moeda();
// var moedaNova = new Moeda("USD", "Dólar");
// var moedaComPais = new Moeda("USD", "Dólar", "Estados Unidos");
// var moeda = new Moeda("", "");
// Console.WriteLine(moeda.Simbolo);

List<Moeda> moedas = new List<Moeda>();
var operacoes = new List<Operacao>();

var dolar = new Moeda("USD", "Dólar");

var real = new Moeda("BRL", "Real");
moedas.Add(real);
moedas.Add(dolar);

// var euro = new Moeda() {
//     Simbolo = "E",
//     Nome = "Euro"
// };

//euro.Nome = "Euro";

// var moedasOrdenadas = moedas.Sort(0, moedas.Count);

foreach(var moeda in moedas.OrderBy(m => m.Nome)) {
    Console.WriteLine(moeda);
}

string moedaDigitada = "BRA";

var moedaDeVenda = moedas.FirstOrDefault<Moeda>(m => m.Simbolo == moedaDigitada);

var moedaDigitadaExiste = moedas.Contains(new  Moeda("USD", "Dólar"));


var operacaoUSDvsBRL = new Operacao(dolar, real);
operacoes.Add(operacaoUSDvsBRL);

var operacaoBRLvsUSD = new Operacao(real, dolar);
operacoes.Add(operacaoBRLvsUSD);



var transacao = new Transacao(new Taxa(operacaoUSDvsBRL, 5, new DateTime()));
var transacao2 = new Transacao(new Taxa(operacaoBRLvsUSD, 4.5, new DateTime()));






