// See https://aka.ms/new-console-template for more information
using Modelos;

// var moeda = new Moeda();
var moedaNova = new Moeda("USD", "Dólar");
var moedaComPais = new Moeda("USD", "Dólar", "Estados Unidos");
var moeda = new Moeda("", "");
Console.WriteLine(moeda.Simbolo);
