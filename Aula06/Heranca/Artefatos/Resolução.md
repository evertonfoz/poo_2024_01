
# Problema para Desenvolvimento em Sala

## Introdução ao Problema

Vamos imaginar um novo contexto. Suponha que você está desenvolvendo um sistema para uma biblioteca. O objetivo é gerenciar diferentes tipos de itens da biblioteca, como livros, revistas e DVDs. Inicialmente, pode parecer uma boa ideia criar classes separadas para cada tipo de item, onde cada classe possui seus próprios atributos e métodos. No entanto, essa abordagem pode se tornar ineficiente e difícil de manter conforme a biblioteca cresce. Vamos explorar uma implementação inicial e identificar os problemas antes de propor uma solução ideal.

### Descobrindo as Propriedades

Para definir as propriedades de cada tipo de item da biblioteca, precisamos pensar nas informações relevantes que cada tipo de item deve armazenar e como essas informações são utilizadas. Vamos analisar cada tipo de item:

#### Livros

Para os livros, precisamos armazenar as seguintes informações:

1. **Título**: Para identificar o livro.
2. **Autor**: Para saber quem escreveu o livro.
3. **ISBN**: Um identificador único para cada livro.
4. **Páginas**: Para saber a extensão do livro.

#### Revistas

Para as revistas, precisamos armazenar:

1. **Título**: Para identificar a revista.
2. **Edição**: Para saber qual edição da revista estamos tratando.
3. **ISSN**: Um identificador único para publicações seriadas como revistas.

#### DVDs

Para os DVDs, precisamos armazenar:

1. **Título**: Para identificar o DVD.
2. **Diretor**: Para saber quem dirigiu o filme.
3. **Duração**: Para saber quanto tempo dura o filme.

Com base nessas informações, podemos criar as classes separadas para cada tipo de item. Vamos ver como fica a implementação inicial.

## Implementação Inicial (Incorreta)

Aqui está uma implementação inicial onde cada tipo de item é representado por uma classe separada:

```csharp
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int Paginas { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Páginas: {Paginas}");
    }
}

public class Revista
{
    public string Titulo { get; set; }
    public int Edicao { get; set; }
    public string ISSN { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Edição: {Edicao}, ISSN: {ISSN}");
    }
}

public class DVD
{
    public string Titulo { get; set; }
    public string Diretor { get; set; }
    public int Duracao { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Diretor: {Diretor}, Duração: {Duracao} minutos");
    }
}
```

## Problemas com a Implementação Inicial

Vamos refletir sobre os problemas dessa abordagem:

1. **Duplicação de Código**: Notem que as classes `Livro`, `Revista` e `DVD` possuem um atributo comum, `Titulo`. Isso é ineficiente porque estamos repetindo o mesmo código em várias classes.
   - **Pergunta**: O que acontece se precisarmos adicionar um novo atributo comum a todos os itens, como `AnoDePublicacao`? Teríamos que modificar cada classe individualmente. Isso parece prático?

2. **Manutenção Difícil**: Se você precisar adicionar ou alterar um atributo comum, terá que fazer isso em várias classes, aumentando a chance de erro.
   - **Pergunta**: Se houver um erro em um atributo comum a todos os itens, como garantiríamos que ele fosse corrigido em todas as classes? Isso é eficiente para um sistema grande?

## Solução Usando Herança por Extensão

Para resolver esses problemas, podemos usar a herança por extensão. Vamos criar uma classe base que contém os atributos comuns e derivar classes específicas dela.

### Implementação Melhorada Usando Herança

```csharp
// Classe base para itens da biblioteca
public class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string AnoDePublicacao { get; set; }

    public ItemBiblioteca(string titulo, string anoDePublicacao)
    {
        Titulo = titulo;
        AnoDePublicacao = anoDePublicacao;
    }

    public virtual void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Ano de Publicação: {AnoDePublicacao}");
    }
}

// Classe derivada para livros
public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int Paginas { get; set; }

    public Livro(string titulo, string anoDePublicacao, string autor, string isbn, int paginas)
        : base(titulo, anoDePublicacao)
    {
        Autor = autor;
        ISBN = isbn;
        Paginas = paginas;
    }

    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Páginas: {Paginas}, Ano de Publicação: {AnoDePublicacao}");
    }
}

// Classe derivada para revistas
public class Revista : ItemBiblioteca
{
    public int Edicao { get; set; }
    public string ISSN { get; set; }

    public Revista(string titulo, string anoDePublicacao, int edicao, string issn)
        : base(titulo, anoDePublicacao)
    {
        Edicao = edicao;
        ISSN = issn;
    }

    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Edição: {Edicao}, ISSN: {ISSN}, Ano de Publicação: {AnoDePublicacao}");
    }
}

// Classe derivada para DVDs
public class DVD : ItemBiblioteca
{
    public string Diretor { get; set; }
    public int Duracao { get; set; }

    public DVD(string titulo, string anoDePublicacao, string diretor, int duracao)
        : base(titulo, anoDePublicacao)
    {
        Diretor = diretor;
        Duracao = duracao;
    }

    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Título: {Titulo}, Diretor: {Diretor}, Duração: {Duracao} minutos, Ano de Publicação: {AnoDePublicacao}");
    }
}

// Exemplo de uso
public class Program
{
    public static void Main()
    {
        Livro livro = new Livro("O Senhor dos Anéis", "1954", "J.R.R. Tolkien", "1234567890", 1178);
        Revista revista = new Revista("National Geographic", "2020", 200, "987654321");
        DVD dvd = new DVD("Inception", "2010", "Christopher Nolan", 148);

        livro.MostrarDetalhes();
        revista.MostrarDetalhes();
        dvd.MostrarDetalhes();
    }
}
```

## Benefícios da Herança por Extensão

Vamos refletir sobre os benefícios que essa abordagem traz:

- **Reutilização de Código**: Reduzimos a duplicação de código comum entre diferentes tipos de itens, facilitando a manutenção.
- **Organização e Estrutura**: A herança permite uma melhor organização do código, refletindo a estrutura lógica da biblioteca.
- **Especialização**: A herança facilita a criação de comportamentos especializados para diferentes tipos de itens, tornando o sistema mais flexível.

## Desvantagens e Considerações

Mas nem tudo são flores. Precisamos estar atentos a alguns pontos:

- **Acoplamento**: A classe derivada depende fortemente da classe base, o que pode dificultar mudanças na classe base.
  - **O que pode ser feito**: Para reduzir o acoplamento, pode-se aplicar o princípio da composição sobre a herança quando apropriado. Utilizar interfaces e injeção de dependência pode ajudar a desacoplar as classes e tornar o sistema mais flexível e testável.

- **Sobrescrita de Métodos**: Precisamos ser cuidadosos ao sobrescrever métodos para garantir que o comportamento desejado seja implementado corretamente.
  - **O que pode ser feito**: Para garantir a correta sobrescrita de métodos, é importante seguir boas práticas de design, como o uso do modificador `override` em linguagens que suportam essa funcionalidade. Além disso, testes unitários extensivos devem ser escritos para validar o comportamento dos métodos sobrescritos.
## Exercícios de Fixação

### Exercícios Teóricos

1. Explique como a herança por extensão ajuda a reduzir a duplicação de código em sistemas empresariais.
2. Descreva um cenário em que a herança por extensão pode ser desfavorável devido ao forte acoplamento entre classes.

### Exercícios Práticos

1. Implemente uma hierarquia de classes para um sistema de gerenciamento escolar, incluindo classes para `Aluno`, `Professor` e `FuncionarioAdministrativo`.
2. Crie uma aplicação que gerencie diferentes tipos de veículos em uma locadora, utilizando herança por extensão para especializar classes como `Carro`, `Moto` e `Caminhao`.

## Próximos Passos

Para obter mais informações e detalhes sobre como implementar corretamente herança por extensão, recomendo revisar a documentação oficial da linguagem C# sobre herança e polimorfismo, bem como explorar recursos educacionais como tutoriais online e livros sobre programação orientada a objetos. Isso ajudará a consolidar os conceitos e melhorar suas habilidades de desenvolvimento.

Ao abordar esses conceitos em sala de aula, incentive os alunos a refletirem sobre os problemas e a participarem ativamente das discussões. Isso ajudará a construir um entendimento mais profundo e prático da importância da herança por extensão.
