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
                throw new Exception("Entrada inválida. Por favor, tente novamente.");
            }
        }
    }