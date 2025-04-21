using Precificacao.Core.Models;
using Precificacao.Core.Services;

var servico = new ServicePrecificacao();

var produtoAlimenticio = new ProdutoAlimenticio
{
    Nome = "Queijo Minas",
    CustoAquisicao = 20.0,
    VolumeOcupado = 0.5,
    PrecisaRefrigeracao = true,
    DataValidade = DateTime.Today.AddDays(8)
};

var produtoNaoPerecivel = new ProdutoNaoPerecivel
{
    Nome = "Sabão em Pó",
    CustoAquisicao = 15.0,
    VolumeOcupado = 0.7
};

double precoAlimento = servico.CalcularPrecoProdutoAlimenticio(produtoAlimenticio);
double precoNaoPerecivel = servico.CalcularPrecoProdutoNaoPerecivel(produtoNaoPerecivel);

Console.WriteLine($"Preço de '{produtoAlimenticio.Nome}': R${precoAlimento:F2}");
Console.WriteLine($"Preço de '{produtoNaoPerecivel.Nome}': R${precoNaoPerecivel:F2}");