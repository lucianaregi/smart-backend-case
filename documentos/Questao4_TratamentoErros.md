# Questão 4 – Tratamento de Erros e Exceções 🚨

Essa questão trata de como lidar com erros no código: quando capturar, quando lançar, e como deixar as exceções mais claras e organizadas.

---

## (a) É boa prática definir uma exceção personalizada?

Sim! Criar uma exceção específica como `CpfInvalidoException` é uma forma muito útil de deixar o código mais **legível** e **expressivo**.

### Por que usar?

- Ajuda a identificar rapidamente a origem do erro
- Facilita o tratamento em partes específicas do sistema
- Deixa mais claro o que foi esperado e o que deu errado

### Exemplo criado:

```csharp
public class CpfInvalidoException : Exception
{
    public CpfInvalidoException(string cpf)
        : base($"O CPF '{cpf}' é inválido.") { }
}
```

---

## (b) Quando capturar uma exceção com `try/catch`?

Tu deves capturar uma exceção quando quiser **tratar a falha** sem deixar o programa quebrar.

### Exemplos de bom uso:

- Exibir uma mensagem pro usuário em vez de estourar o erro no console
- Registrar o erro e seguir a execução
- Fazer uma tentativa alternativa (fallback)

### No exemplo:

```csharp
try
{
    validador.Validar(cpf);
    Console.WriteLine("CPF válido");
}
catch (CpfInvalidoException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```

---

## (c) Em que situações lançar uma exceção?

Tu lanças uma exceção quando **o fluxo não pode continuar de forma segura** ou **os dados estão fora do esperado**.

### Exemplo no projeto:

No `ValidadorCpfService`, o método `Validar` lança uma exceção se o CPF for nulo, inválido ou mal formatado:

```csharp
if (cpf.Length != 11 || TodosDigitosIguais(cpf) || !DigitosVerificadoresValidos(cpf))
{
    throw new CpfInvalidoException(cpf);
}
```

---

## 🔍 O que foi implementado?

- Uma exceção específica (`CpfInvalidoException`)
- Um serviço (`ValidadorCpfService`) que valida estrutura e dígitos
- Um `Program.cs` que mostra como tratar erros e continuar rodando

---

## 📁 Exemplos de código

Os arquivos com a exceção personalizada, a lógica de validação de CPF e o tratamento com `try/catch` estão em:

📂 `codigo/Questao4_TratamentoErros/`

- `Excecoes/CpfInvalidoException.cs`
- `Servicos/ValidadorCpfService.cs`
- `Apresentacao/Program.cs`
