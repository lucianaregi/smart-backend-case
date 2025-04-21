namespace Precificacao.Core.Models;

public class ProdutoAlimenticio : IItemEstoque
{
    public double CustoAquisicao { get; set; }
    public double VolumeOcupado { get; set; } // em m³
    public bool PrecisaRefrigeracao { get; set; }
    public DateTime DataValidade { get; set; }
    public string Nome { get; set; }

    public double CalcularCusto()
    {
        double custoBase = CustoAquisicao;
        custoBase += VolumeOcupado * 5.0;
        if (PrecisaRefrigeracao)
            custoBase += 1.5;

        int diasValidade = ObterValidadeEmDias();
        if (diasValidade < 10)
            custoBase *= 1.05;

        return custoBase;
    }

    public int ObterValidadeEmDias()
    {
        TimeSpan diff = DataValidade.Date - DateTime.Today;
        return Math.Max(0, (int)diff.TotalDays);
    }
}