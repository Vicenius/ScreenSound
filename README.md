# ScreenSound

Aplicação de console em C# para cadastrar bandas, registrar avaliações e consultar a média das notas. Projeto de estudo dos fundamentos da linguagem e de coleções do .NET.

## Funcionalidades

- Exibe um menu para registrar bandas, listar bandas, avaliar uma banda, consultar a média das avaliações ou sair.
- Inicializa algumas bandas com avaliações de exemplo.
- Permite adicionar novas bandas durante a execução.
- Armazena avaliações associadas a cada banda e calcula a média com LINQ.
- Apresenta títulos de seção no console.

## Tecnologias

- C#
- .NET 10
- Aplicação de console
- `Dictionary<string, List<int>>`, métodos locais, estruturas condicionais e de repetição, LINQ e interação via `Console`.

## Como executar

Instale o SDK do .NET 10 e, na raiz do repositório, execute:

```bash
dotnet run --project ScreenSound.csproj
```

## Observações

As bandas e avaliações ficam somente em memória e são reiniciadas quando o programa termina. As notas de exemplo são inicializadas no código. Entradas são convertidas com `int.Parse` sem tratamento de erros, e as notas não têm validação de faixa. Uma banda recém-cadastrada começa sem avaliações; ao consultar sua média antes de registrar uma nota, o resultado não representa uma média numérica válida. O menu também retorna a outras opções por chamadas recursivas, algo que pode ser substituído por um laço para evitar crescimento da pilha.

O projeto foi preparado a partir do `ProgramScreen.cs` enviado. O arquivo `ScreenSound.csproj` foi acrescentado para permitir abrir e executar o código como projeto .NET.
