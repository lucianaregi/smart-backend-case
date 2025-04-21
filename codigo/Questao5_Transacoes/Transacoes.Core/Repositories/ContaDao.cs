using Transacoes.Core.Models;

namespace Transacoes.Core.Repositories;

public class ContaDao : IContaDao
{
    private readonly Dictionary<long, Conta> contas = new();

    public ContaDao()
    {
        contas[1] = new Conta(1, 1000);
    }

    public Conta BuscarConta(long idConta)
    {
        if (!contas.TryGetValue(idConta, out var conta))
            throw new Exception($"Conta com ID {idConta} não encontrada.");

        return conta;
    }

    public void AtualizarConta(Conta conta)
    {
        contas[conta.Id] = conta;
    }
}
