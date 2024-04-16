using Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

var pais01 = new Pais("BR", "BRasil");
Pais pais02 = new("PY", "Paraguai");

new Estado("PR", "Paraná", pais01);
var estado01 = new Estado("SP", "São Paulo");
estado01.RegistrarPais(pais02);
// pais02.Estados.Add(estado01);
// pais02.Estados.Add(new Estado( "RS", "Rio Grande do Sul"));

var pais03 = new Pais("AR", "Argentina");
new Estado("SC", "Santa Catarina", pais03);




// var estadoPais01 = pais01.Estados[0];
// estadoPais01 = new Estado("SP", "São Paulo");

Console.ReadLine();


// using Utfpr.Poo.Aula05.Exercicio01.Model.EnderecoModel;

// Pais pais = new("BR", "Brasil");
// pais.AdicionarEstado( new Estado("PR", "Paraná"));
// pais.AdicionarEstado(new Estado("SP", "São Paulo"));
// pais.Estados.Add();

// Console.WriteLine(pais.Estados);

// {
    
    // class ContaBancaria
    // {
    //     private int Numeroconta { get; set; }
    //     private string Nome { get; set; }
    //     private double Saldo { get; set; }

    //     public void ExibirDados()
    //     {
    //         Console.WriteLine($"numero da conta : {Numeroconta}");
    //         Console.WriteLine($"email: {Nome}");
    //         Console.WriteLine($"endereço:{Saldo}");
    //         Console.ReadLine();

    //     }
    //     public void Depositar()
    //     {

    //         Console.WriteLine("insira a quantidade que deseja adicionar a sua conta:");
    //         double deposito = Convert.ToDouble(Console.ReadLine());
    //         Saldo = Saldo + deposito;
    //         Console.WriteLine($"foram adicionados {deposito} a  conta o saldo atual é de {Saldo}");
    //         Console.ReadLine();

    //     }
    //     public void Sacar()
    //     {
    //         Console.WriteLine("digite a quantidade que deseja retirar:");
    //         double saque = Convert.ToDouble(Console.ReadLine());
    //        while  (saque > Saldo)
    //         {
    //             Console.WriteLine("digite um valor de saque valido");
    //             saque = Convert.ToDouble(Console.ReadLine());
    //         }
    //         Saldo = Saldo - saque;
    //         Console.WriteLine($"foram sacados{saque} da conta o valor que sobrou foi {Saldo}");
    //         Console.ReadLine();

    //     }

    //     public void Transferir()
    //     {
    //         Console.WriteLine("insira o numero da conta destino: ");
    //         int contadestino = int.Parse(Console.ReadLine());
    //         Console.WriteLine("insira o valor a ser transferido:");
    //         int transferido = int.Parse(Console.ReadLine());
    //         while (transferido > Saldo)
    //         {
    //             Console.WriteLine("digite um valor valido");
    //             transferido = int.Parse(Console.ReadLine());
    //         }

    //         double valordestino = 0;
    //         valordestino = valordestino + transferido;
    //         Saldo = Saldo - transferido;
    //         Console.WriteLine($"foram transferidos {transferido} para a conta{contadestino} o valor do seu saldo agora é de {Saldo}");
    //         Console.ReadLine();

    //     }
    //     public void inserirdados()
    //     {
    //         Console.WriteLine("insira o numero da conta:");
    //         Numeroconta = int.Parse(Console.ReadLine());
    //         Console.WriteLine("insira o nome do cliente que mantem a conta ");
    //         Nome = Console.ReadLine();
    //         Console.WriteLine("insira o saldo da conta");
    //         Saldo = Convert.ToDouble(Console.ReadLine());



    //     }
    //     public void DefinirDados()
    //     {
    //         Saldo = 300;
    //         Numeroconta = 2;
    //         Nome = "nick";
    //     }
    // }
    // class program
    // {
    //     static void Main(string[] args)
    //     {
    //         int opcao = 0;
            
    //         Cliente cliente = new Cliente();
    //         cliente.DefinirDados();
    //         ContaBancaria contabancaria = new ContaBancaria();
    //         contabancaria.DefinirDados();
           
    //         do
    //         {
               
    //             Console.WriteLine("escolha uma operação: 1- atualizar os adicionar dados de cliente 2- sacar 3-depositar 4-transferir" );
    //             Console.WriteLine("5 - exibir dados do cliente  6 - inserir dados da conta  7 - exibir dados da conta 8 - encerrar programa");
    //             opcao = int.Parse(Console.ReadLine());





    //             switch (opcao)
    //             {
    //                 case 1: cliente.AdicionararDados(); break;
    //                 case 2: contabancaria.Sacar(); break;
    //                 case 3: contabancaria.Depositar(); break;
    //                 case 4: contabancaria.Transferir(); break;
    //                 case 5: cliente.ExibirDados(); break;
    //                 case 6: contabancaria.inserirdados(); break;
    //                 case 7: contabancaria.ExibirDados(); break;
    //                 case 8: break;



    //             }
    //         } while (opcao != 8);




    // }
    // } }
