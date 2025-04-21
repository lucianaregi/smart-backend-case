namespace Precificacao.Core.Models;

public class ProdutoNaoPerecivel : IItemEstoque
{
    public double CustoAquisicao { get; set; }
    public double VolumeOcupado { get; set; } // em m³
    public string Nome { get; set; }

    public double CalcularCusto()
    {
        double custoBase = CustoAquisicao;
        custoBase += VolumeOcupado * 3.0; // custo menor por volume
        return custoBase;
    }
}
