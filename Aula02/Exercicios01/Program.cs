// Exibir todos os números na console
// Número não pode ser negativo e não pode ser zero
// É decrescente

//Console.WriteLine("Digite um número para realizar a contagem regressiva");

int numeroInicial=0;

do {
    Console.WriteLine("Digite um número MAIOR QUE ZERO para realizar a contagem regressiva");
    try {
        numeroInicial = int.Parse(Console.ReadLine());
    } catch(Exception e) {
        Console.WriteLine("É  preciso informar um valor MAIOR QUE ZERO. Tente novamente");
    }

/*    if (valorInformado == "") {
        Console.WriteLine("É  preciso informar um valor MAIOR QUE ZERO");
        continue;
    }
    numeroInicial = int.Parse(valorInformado??"0"); */

} while(numeroInicial<=0);

/*string? valorInformado = Console.ReadLine();
if (valorInformado == "") {
    Console.WriteLine("É preciso informar um valor MAIOR QUE ZERO");
}
int numeroInicial = int.Parse(valorInformado);
*/

//int numeroInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Contando");

do {
    Console.WriteLine(numeroInicial--);
}while(numeroInicial>0);

Console.WriteLine("Concluído");

