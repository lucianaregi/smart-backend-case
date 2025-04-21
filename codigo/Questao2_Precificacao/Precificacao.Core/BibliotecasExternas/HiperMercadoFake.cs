namespace Precificacao.Core.BibliotecasExternas;

public static class HiperMercado
{
    public static class Hi
    {
        public static double FormulaMagica(double custo, int validade)
        {
            return custo + (validade > 0 ? (100.0 / validade) : 10);
        }
    }
}
