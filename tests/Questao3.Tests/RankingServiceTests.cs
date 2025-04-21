using Xunit;
using RankingRuas.Core.Models;
using RankingRuas.Core.Services;
using System.Collections.Generic;

namespace Questao3.Tests;

public class RankingServiceTests
{
    [Fact]
    public void DeveRetornarRuasOrdenadasPorTotalDeEleitores()
    {
        var casas = new List<Casa>
        {
            new Casa { Rua = new Rua { Nome = "Rua A", Cep = "00000-000" }, Numero = 10, TotalEleitores = 3 },
            new Casa { Rua = new Rua { Nome = "Rua B", Cep = "11111-111" }, Numero = 20, TotalEleitores = 5 },
            new Casa { Rua = new Rua { Nome = "Rua A", Cep = "00000-000" }, Numero = 11, TotalEleitores = 2 }
        };

        var service = new RankingService();
        var ranking = service.RankRuasPorEleitores(casas);

        Assert.Equal("Rua A", ranking[0].Nome); 
        Assert.Equal("Rua B", ranking[1].Nome); 
    }

    [Fact]
    public void DeveRetornarListaVazia_QuandoNaoHouverCasas()
    {
        var service = new RankingService();
        var ranking = service.RankRuasPorEleitores(new List<Casa>());

        Assert.Empty(ranking);
    }
}
