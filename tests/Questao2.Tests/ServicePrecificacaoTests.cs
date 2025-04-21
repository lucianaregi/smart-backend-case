using Xunit;
using Precificacao.Core.Models;
using Precificacao.Core.Services;

namespace Questao2.Tests;

public class ServicePrecificacaoTests
{
    [Fact]
    public void DeveCalcularPrecoParaProdutoNaoPerecivel_ComSucesso()
    {
        var produto = new ProdutoNaoPerecivel
        {
            CustoAquisicao = 20,
            VolumeOcupado = 2,
            Nome = "Notebook"
        };

        var servico = new ServicePrecificacao();
        var preco = servico.CalcularPrecoProdutoNaoPerecivel(produto);

        Assert.True(preco > 20); 
    }

    [Fact]
    public void DeveFalhar_QuandoPrecoForMenorQueEsperado()
    {
        var produto = new ProdutoNaoPerecivel
        {
            CustoAquisicao = 10,
            VolumeOcupado = 0,
            Nome = "Item teste"
        };

        var servico = new ServicePrecificacao();
        var preco = servico.CalcularPrecoProdutoNaoPerecivel(produto);

        Assert.True(preco > 30); 
    }
}
