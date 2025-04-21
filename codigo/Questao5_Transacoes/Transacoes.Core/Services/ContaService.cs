using System.Transactions;
using Transacoes.Core.Models;
using Transacoes.Core.Repositories;
using Transacoes.Core.Excecoes;

namespace Transacoes.Core.Services;

public class ContaService
{
    private readonly IContaDao _dao;

    public ContaService(IContaDao dao)
    {
        _dao = dao;
    }

    public void Debitar(long idConta, double valor)
    {
        using var scope = new TransactionScope();

        var conta = _dao.BuscarConta(idConta);

        lock (conta)
        {
            if (!conta.PodeDebitar(valor))
                throw new SaldoInsuficienteException();

            conta.Debitar(valor);
            _dao.AtualizarConta(conta);
        }

        scope.Complete();
    }

    public void Creditar(long idConta, double valor)
    {
        using var scope = new TransactionScope();

        var conta = _dao.BuscarConta(idConta);

        lock (conta)
        {
            conta.Creditar(valor);
            _dao.AtualizarConta(conta);
        }

        scope.Complete();
    }
}
