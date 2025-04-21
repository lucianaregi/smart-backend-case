using RankingRuas.Core.Models;
using RankingRuas.Core.Services;


var casas = new List<Casa>
{
    new Casa { Rua = new Rua { Cep = "12345-000", Nome = "Rua das Palmeiras" }, Numero = 101, TotalEleitores = 5 },
    new Casa { Rua = new Rua { Cep = "12345-000", Nome = "Rua das Palmeiras" }, Numero = 102, TotalEleitores = 1 },
    new Casa { Rua = new Rua { Cep = "12345-111", Nome = "Rua dos Jacarandás" }, Numero = 10, TotalEleitores = 7 },
    new Casa { Rua = new Rua { Cep = "12345-222", Nome = "Rua dos Pinheiros" }, Numero = 5, TotalEleitores = 3 },
};

var service = new RankingService();
var ranking = service.RankRuasPorEleitores(casas);

Console.WriteLine("Ranking de ruas por total de eleitores:");
int posicao = 1;
foreach (var rua in ranking)
{
    var total = casas.Where(c => c.Rua == rua).Sum(c => c.TotalEleitores);
    Console.WriteLine($"{posicao++}º - {rua.Nome} ({total} eleitores)");
}

