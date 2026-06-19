# Exercício: Padrão Template Method

## O que o projeto faz?

O programa organiza uma lista de palavras de duas formas diferentes, mas ambas usam a **ordem alfabética como critério de desempate padrão**:

1. **Por Tamanho:** Organiza as palavras da menor para a maior.
2. **Por Última Letra:** Organiza as palavras baseando-se na última letra de cada uma.

---

## Como o código foi estruturado?

* **`ComparadorPalavraBase.cs`**: Classe base abstrata. Ela implementa a interface `IComparer<string>` e cuida de toda a lógica principal, como validações de nulos e o critério de desempate padrão (ordem alfabética) caso as subclasses deem empate.
* **`ComparadorTamanho.cs`**: Subclasse que herda da base e substitui o critério principal para comparar o tamanho das palavras (`Length`).
* **`ComparadorUltimaLetra.cs`**: Subclasse que herda da base e isola a última letra de cada palavra para fazer a comparação.
* **`Program.cs`**: Classe com o método `Main` onde criei um array de strings bagunçado e usei o `Array.Sort()` passando os meus comparadores customizados para testar se tudo estava funcionando na prática.

---

## Como rodar o projeto?

O repositório já está configurado com o arquivo `.csproj`. Para rodar, basta abrir o terminal na pasta do projeto e executar o comando:

```bash
dotnet run
