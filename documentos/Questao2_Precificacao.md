# Questão 2 – Precificação com fórmula mágica 🧪✨

Nesta questão, é preciso criar uma solução orientada a objetos que use uma fórmula mágica fornecida por uma biblioteca externa chamada `HiperMercado.Hi`.

A fórmula serve pra calcular o **preço de um item do estoque** com base em:

- custo (em reais)
- validade (em dias)

---

## 📦 A Fórmula Mágica

A função da biblioteca é assim:

```csharp
public static double FormulaMagica(double custo, int validade)
{
    return custo + (validade > 0 ? (100.0 / validade) : 10);
}
```

---

## 💡 Modelagem com domínio

### Interface `IItemEstoque`

Criei uma interface de domínio `IItemEstoque`, pra definir um contrato comum entre qualquer tipo de item do estoque:

```csharp
public interface IItemEstoque
{
    double CalcularCusto();
    string Nome { get; }
}
```

---

## 🍞 ProdutoAlimenticio com regras de precificação

A classe `ProdutoAlimenticio` implementa a interface e traz lógica baseada nas seguintes regras de precificação:

- Custo de aquisição
- Volume ocupado no estoque
- Custo adicional por refrigeração
- Risco se a validade estiver próxima

```csharp
public double CalcularCusto()
{
    double custoBase = CustoAquisicao;
    custoBase += VolumeOcupado * 5.0;
    if (PrecisaRefrigeracao) custoBase += 1.5;
    if (ObterValidadeEmDias() < 10) custoBase *= 1.05;
    return custoBase;
}
```

---

## 📦 ProdutoNaoPerecivel

Mesmo sem validade, ele também implementa a interface e tem um cálculo simplificado:

```csharp
public double CalcularCusto()
{
    return CustoAquisicao + VolumeOcupado * 3.0;
}
```

---

## 🔧 Serviço de precificação

A lógica de chamada à `FormulaMagica` foi isolada no `ServicoPrecificacao`:

```csharp
public double CalcularPrecoProdutoAlimenticio(ProdutoAlimenticio produto)
{
    return HiperMercado.Hi.FormulaMagica(produto.CalcularCusto(), produto.ObterValidadeEmDias());
}

public double CalcularPrecoProdutoNaoPerecivel(ProdutoNaoPerecivel produto)
{
    return HiperMercado.Hi.FormulaMagica(produto.CalcularCusto(), 0);
}
```

---

## 🧠 Cálculo total de estoque (extra)

Com a interface, ficou possível iterar sobre qualquer tipo de item:

```csharp
public double CalcularCustoTotalEstoque(IEnumerable<IItemEstoque> itens)
{
    return itens.Sum(item => item.CalcularCusto());
}
```
