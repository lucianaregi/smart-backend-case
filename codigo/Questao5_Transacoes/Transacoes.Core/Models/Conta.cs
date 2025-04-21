namespace Transacoes.Core.Models;

public class Conta
{
    public long Id { get; set; }
    public double Saldo { get; private set; }

    public Conta(long id, double saldo)
    {
        Id = id;
        Saldo = saldo;
    }

    public bool PodeDebitar(double valor) => valor <= Saldo;

    public void Debitar(double valor)
    {
        Saldo -= valor;
    }

    public void Creditar(double valor)
    {
        Saldo += valor;
    }
}
