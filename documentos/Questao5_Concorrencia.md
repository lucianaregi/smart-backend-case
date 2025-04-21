# Questão 5 – Concorrência e Escopo de Transações 💳🔄

Essa questão propõe a análise de uma operação de débito e crédito em uma conta, implementada como um web service.

---

## 🧠 O que foi pedido?

> Analisar a solução, considerando **concorrência entre chamadas** e **escopo de transações**.

---

## 🚨 Problemas possíveis na versão original

### 1. Concorrência

Se duas chamadas `debitar()` forem feitas ao mesmo tempo para a **mesma conta**, elas podem:

- ambas passar na verificação `podeDebitar(valor)`
- ambas realizarem o débito
- e no fim, o saldo pode ficar negativo mesmo com a verificação

### 2. Escopo de transação

Não há uma transação envolvida para garantir que as operações de `debite()` e `atualiza()` aconteçam juntas.  
Se ocorrer uma falha entre essas duas etapas, a conta pode ficar num estado inconsistente.

---

## ✅ O que foi implementado

### Estrutura criada

- `Conta`: representa a conta bancária
- `ContaDao`: simula o acesso ao "banco de dados"
- `IContaDao`: interface para manter baixo acoplamento
- `ContaService`: contém as regras de negócio
- `SaldoInsuficienteException`: exceção lançada quando não há saldo suficiente

### Regras aplicadas

- Uso de `TransactionScope` para garantir atomicidade
- Uso de `lock(conta)` para controlar concorrência local por instância
- Interface para facilitar testes e seguir boas práticas

---

## 💡 Como poderia melhorar?

Em cenários maiores ou reais:

- Usar locks globais ou mecanismos distribuídos
- Garantir atomicidade no banco de dados real
- Lidar com falhas inesperadas entre etapas críticas
- Usar `try/catch` mais granulares ou monitoramento centralizado

---

## 🧪 Testes no Program.cs

O exemplo de execução está em:
📁 `codigo/Questao5_Transacoes/Transacoes.Apresentacao/Program.cs`

### Situações demonstradas:

| Situação                        | Resultado esperado             |
| ------------------------------- | ------------------------------ |
| Débito com saldo disponível     | Sucesso                        |
| Débito com valor acima do saldo | `SaldoInsuficienteException`   |
| Crédito após débito             | Sucesso                        |
| Débito em conta inexistente     | `Exception` com mensagem clara |

---
