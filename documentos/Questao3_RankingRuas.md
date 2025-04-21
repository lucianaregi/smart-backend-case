# Questão 3 – Ranking de Ruas por Eleitores 🏡✨

Nesta questão, é preciso criar um método que recebe uma `List<Casa>` e retorna uma `List<Rua>`, ordenada de forma decrescente pelo total de eleitores.

---

## ✅ Requisitos atendidos

- [x] Usa obrigatoriamente um `Dictionary<Rua, int>` para mapear os totais
- [x] Ordena corretamente do maior para o menor número de eleitores
- [x] Retorna somente a lista de `Rua`, como solicitado
- [x] Possui modelagem de domínio (`Rua`, `Casa`)
- [x] Código limpo e separado em camada de serviço (`RankingService`)

---

## 🧠 Modelagem usada

### `Rua.cs`

- Tem `Nome` e `Cep`
- Implementa `IEquatable<Rua>` para permitir agrupamento em `Dictionary`

### `Casa.cs`

- Representa uma residência
- Contém a rua, o número e a quantidade de eleitores

---

## 🧮 Lógica de agrupamento e ordenação

Foi utilizado um `Dictionary<Rua, int>` para acumular os eleitores de cada rua:

```csharp
var eleitoresPorRua = new Dictionary<Rua, int>();
```

Depois, as ruas são ordenadas por esse total de forma decrescente e retornadas em uma lista.

---

## 🧪 Exemplo de execução (Program.cs)

```plaintext
Ranking de ruas por total de eleitores:
1º - Rua dos Jacarandás (7 eleitores)
2º - Rua das Palmeiras (6 eleitores)
3º - Rua dos Pinheiros (3 eleitores)
```

---

## 📁 Exemplos de código

Os arquivos com a modelagem e a lógica de ranking por número de eleitores estão em:

📂 `codigo/Questao3_RankingRuas/`

- `Modelos/Casa.cs`
- `Modelos/Rua.cs`
- `Servicos/RankingService.cs`
- `Apresentacao/Program.cs`

---

## 🧪 Testes automatizados

O código da Questão 3 está coberto por testes com xUnit.

📁 Local dos testes: [`tests/Questao3.Tests/`](../../tests/Questao3.Tests/)
