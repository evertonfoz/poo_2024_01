while (true)
{
    try {
        Console.Write("Digite um número inteiro e positivo para o fatorial: ");
        var numeroParaFatorial = LerInteiroPositivo();
        CalcularFatorial(numeroParaFatorial);
        break;
    } catch(Exception exception) {
        Console.WriteLine(exception.Message);
        Console.WriteLine("Tente novamente");
    }
}

void CalcularFatorial(int numero) {
    var fatorial = numero;
for (int i = numero - 1; i >= 1; i--)
    {
        fatorial *= i;
    }
    Console.WriteLine($"\nFatorial de {numero} é {fatorial}");
}

 int LerInteiroPositivo()
    {
        while (true)
        {
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero) && numero > 0)
            {
                return numero;
            }
            else
            {
                throw new Exception("Entrada inválida.");
            }
        }
    }