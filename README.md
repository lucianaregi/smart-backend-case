# 💼 Smart Backend Case

Este repositório reúne desafios práticos de back-end com foco em:

- Domínio de conceitos de orientação a objetos
- Boas práticas de design e arquitetura
- Tratamento de erros
- Lógica de negócio
- Manipulação de banco de dados com SQL
- Testes automatizados com xUnit

---

## 📁 Estrutura do Projeto

```
SmartBackendCase/
│
├── codigo/                  ← Código-fonte organizado por questão
│   ├── Questao2_Precificacao/
│   ├── Questao3_RankingRuas/
│   ├── Questao4_TratamentoErros/
│   ├── Questao5_Transacoes/
│   └── Questao6_SQL/
│
├── documentos/              ← Explicações teóricas e complementares
│   ├── Questao1_Conceitos_OO.md
|	├── Questao2_Precificacao.md
│   ├── Questao3_RankingRuas.md
│   ├── Questao4_TratamentoErros.md
│   ├── Questao5_Concorrencia.md
│   └── Questao6_SQL.md
│
├── exemplos/                ← Exemplos de código explicativos (Q1)
│   └── Questao1/
│
└── tests/                   ← Testes automatizados com xUnit
    ├── Questao2.Tests/
    ├── Questao3.Tests/
    └── Questao4.Tests/
```

---

## ✅ Questões resolvidas

### 🧠 [Questão 1 – Orientação a Objetos](documentos/Questao1_Conceitos_OO.md)

- Conceitos de interface, classe abstrata, herança e delegação
- Exemplo de código em [`exemplos/Questao1/Resposta.cs`](exemplos/Questao1/Resposta.cs)

---

### 🧪 [Questão 2 – Precificação com fórmula mágica](documentos/Questao2_Precificacao.md)

- Modelagem com interface de domínio (`IItemEstoque`)
- Regras distintas para produtos perecíveis e não perecíveis
- Código: [`codigo/Questao2_Precificacao/`](codigo/Questao2_Precificacao/)
- Testes: [`tests/Questao2.Tests/`](tests/Questao2.Tests/)

---

### 🏡 [Questão 3 – Ranking de ruas por número de eleitores](documentos/Questao3_RankingRuas.md)

- Agrupamento com `Dictionary<Rua, int>`
- Ordenação decrescente + desempate por nome
- Código: [`codigo/Questao3_RankingRuas/`](codigo/Questao3_RankingRuas/)
- Testes: [`tests/Questao3.Tests/`](tests/Questao3.Tests/)

---

### 🚨 [Questão 4 – Tratamento de exceções e validação de CPF](documentos/Questao4_TratamentoErros.md)

- Exceção personalizada `CpfInvalidoException`
- Serviço com regras reais de validação de CPF
- Código: [`codigo/Questao4_TratamentoErros/`](codigo/Questao4_TratamentoErros/)
- Testes: [`tests/Questao4.Tests/`](tests/Questao4.Tests/)

---

### 💳 [Questão 5 – Concorrência e transações bancárias](documentos/Questao5_Concorrencia.md)

- `TransactionScope` para atomicidade
- `lock` para controle concorrente
- Interface `IContaDao` para desacoplamento
- Código: [`codigo/Questao5_Transacoes/`](codigo/Questao5_Transacoes/)

---

### 🧼 [Questão 6 – SQL para geração de kits promocionais](documentos/Questao6_SQL.md)

- Uso de CTE, JOINs e cálculos de lucro
- Query ordena combinações mais lucrativas
- Script: [`codigo/Questao6_SQL/script.sql`](codigo/Questao6_SQL/script.sql)

---

## 🧪 Testes Automatizados

Todas as questões de código possuem **projetos de teste separados com xUnit**, demonstrando:

- Sucesso e falha proposital
- Validações e regras
- Testes simples e focados

---

## ✨ Considerações finais

Esse projeto foi feito com atenção aos detalhes, boas práticas e clareza de raciocínio.  
Tudo estruturado para ser fácil de ler, entender e manter.
