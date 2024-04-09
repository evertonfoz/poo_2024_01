using Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

namespace Utfpr.Poo.Aula05.Exercicio01.Model;

    class Cliente
    {
        public string Email { get; init; }

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }

       
        // public void AdicionararDados()
        // {
        //     Teste teste = new Teste();
        //     Console.WriteLine("digite o nome do cliente:");
        //     Nome = Console.ReadLine();

        //     Console.WriteLine("digite o email do cliente");
        //     Email = Console.ReadLine();

        //     Console.WriteLine("digite o endereço do cliente");
        //     Endereco = Console.ReadLine();

        //     Console.WriteLine($"nome: {Nome}");
        //     Console.WriteLine($"email: {Email}");
        //     Console.WriteLine($"endereço:{Endereco}");

        // } 
        // public void DefinirDados()
        // {
            
        //     Nome =   "nick";
        //     Email = "nick22";
        //     Endereco = "brasil";
        // }
        // public void ExibirDados()
        // {
        //     Console.WriteLine($"nome: {Nome}");
        //     Console.WriteLine($"email: {Email}");
        //     Console.WriteLine($"endereço:{Endereco}");
        //     Console.ReadLine();

        // }

    }
