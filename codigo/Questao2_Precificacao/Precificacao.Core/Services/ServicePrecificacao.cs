using Precificacao.Core.Models;
using Precificacao.Core.BibliotecasExternas;

namespace Precificacao.Core.Services;

public class ServicePrecificacao
{
    public double CalcularPrecoProdutoAlimenticio(ProdutoAlimenticio produto)
    {
        double custo = produto.CalcularCusto();
        int validade = produto.ObterValidadeEmDias();

        return HiperMercado.Hi.FormulaMagica(custo, validade);
    }

    public double CalcularPrecoProdutoNaoPerecivel(ProdutoNaoPerecivel produto)
    {
        double custo = produto.CalcularCusto();
        return HiperMercado.Hi.FormulaMagica(custo, 0); 
    }
    
    public double CalcularCustoTotalEstoque(IEnumerable<IItemEstoque> itens)
    {
        return itens.Sum(item => item.CalcularCusto());
    }
}
