namespace Transacoes.Core.Excecoes;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() : base("Saldo insuficiente para realizar a operação.") { }
}
