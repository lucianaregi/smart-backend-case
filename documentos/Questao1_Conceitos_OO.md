# Questão 1 – Conceitos de Orientação a Objetos

---

## (a) Interface ou Classe Abstrata? Quando usar cada uma?

### Interface

Ideal quando tu queres só definir um **contrato** entre classes, sem te preocupar com a implementação.

- Define _o que_ precisa ser feito
- Não possui lógica por padrão, leve, desacoplada
- Uma classe pode implementar várias interfaces

**Exemplo:**

```csharp
public interface INotificavel
{
    void Notificar(string mensagem);
}
```

### Classe Abstrata

Use **classe abstrata** quando tu queres fornecer uma **estrutura base**, com possibilidade de implementar parte da lógica.

- Pode conter métodos abstratos e concretos
- Permite reutilizar código
- É usada com herança única

**Exemplo:**

```csharp
public abstract class NotificadorBase
{
    public abstract void Notificar(string mensagem);

    public void Log(string mensagem)
    {
        Console.WriteLine($"[LOG] {mensagem}");
    }
}
```

---

## (b) Herança ou Delegação? Quando usar?

### Herança

Use **herança** quando a relação for do tipo "**é um(a)**".

- Cria vínculo direto entre as classes
- Compartilha comportamento
- Pode levar a acoplamento forte se mal usada

**Exemplo:**

```csharp
public class EmailNotificador : NotificadorBase
{
    public override void Notificar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail: {mensagem}");
    }
}
```

### Delegação

Use **delegação** quando uma classe precisa utilizar a funcionalidade de outra, sem herdar dela.

- Menor acoplamento
- Permite composição
- Mais flexível e reutilizável

**Exemplo:**

```csharp
public class ServicoEmail
{
    public void Enviar(string conteudo)
    {
        Console.WriteLine($"Email enviado: {conteudo}");
    }
}

public class Usuario
{
    private ServicoEmail emailService = new ServicoEmail();

    public void Avisar()
    {
        emailService.Enviar("Bem-vinda!");
    }
}
```
