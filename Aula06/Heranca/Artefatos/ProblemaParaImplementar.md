
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