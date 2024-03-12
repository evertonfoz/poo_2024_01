// Ao receber o número informado pelo usuário,
// dar a ele, uma dica se o número digitado
// é maior ou igual ao gerado pelo aplicativo
// Número aleatorio precisa estar em 0 e 100

// Limitar para apenas valores positivos

/*var randomize = new Random();

var random = randomize.NextInt64();*/

var numeroAleatorio = new Random().Next(100);
int numeroInformado;
int numeroDeTentativas = 0;

do {
    numeroDeTentativas++;
    numeroInformado = LerInteiroPositivo();
    if (numeroInformado > numeroAleatorio) {
        Console.WriteLine("Número informado maior que o sorteado");
    } else if (numeroInformado < numeroAleatorio) {
        Console.WriteLine( "Número informado menor que o sorteado");
    }
}while(numeroInformado!= numeroAleatorio);
Console.WriteLine($"Você acertou em {numeroDeTentativas} tentativa(s). Parabéns!");





 int LerInteiroPositivo()
    {
    while (true)
    {
        Console.Write("Digite um número inteiro positivo (Máximo 100): ");
        string entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int numero) && numero > 0)
        {
            return numero;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
        }
    }
}