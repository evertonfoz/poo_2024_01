using HerancaPorExtensao.Correto;

var dev = new Desenvolvedor("Ana", 101, 6000m, "C#");
Gerente gerente = new("Carlos", 102, 8000m, 10);
var func = new Funcionario("Josueldo", 1, 2);
// string nome = "Cleucio";

var funcionarios= new List<Funcionario>
{
    dev,
    gerente,
    func,
    // nome,
};

foreach(var funcionario in funcionarios) {
    funcionario.Trabalhar();
}



// dev.Trabalhar();
// gerente.Trabalhar();