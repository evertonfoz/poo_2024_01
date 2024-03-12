Console.WriteLine("Cálculo de Média Escolar");
Console.Write("Digite a quantidade de disciplinas: ");

/* Clean Code // Código Limpo */

int quantidadeDeDisciplinas = int.Parse(Console.ReadLine()??"0");

if (quantidadeDeDisciplinas== 0) {
    return;
}

double somaDeNotas = 0;
for(int i=0; i<quantidadeDeDisciplinas;i++) {
    Console.Write($"Digite a nota da disciplina {i+1}: ");
    double nota = double.Parse(Console.ReadLine()??"0.0");

    somaDeNotas+= nota;
}

double media = somaDeNotas/quantidadeDeDisciplinas;
Console.WriteLine( $"A média de notas é {media}");
Console.ReadKey();

