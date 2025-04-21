using Xunit;
using Transacoes.Core.Repositories;
using Transacoes.Core.Services;
using Transacoes.Core.Excecoes;

namespace Questao5.Tests;

public class ContaServiceTests
{
    [Fact]
    public void DeveDebitarComSucesso_QuandoSaldoSuficiente()
    {
        var dao = new ContaDao();
        var service = new ContaService(dao);

        service.Debitar(1, 100);

        var conta = dao.BuscarConta(1);
        Assert.Equal(900, conta.Saldo);
    }

    [Fact]
    public void DeveLancarExcecao_QuandoSaldoInsuficiente()
    {
        var dao = new ContaDao();
        var service = new ContaService(dao);

        Assert.Throws<SaldoInsuficienteException>(() => service.Debitar(1, 2000));
    }

    [Fact]
    public void DeveCreditarComSucesso()
    {
        var dao = new ContaDao();
        var service = new ContaService(dao);

        service.Creditar(1, 300);

        var conta = dao.BuscarConta(1);
        Assert.Equal(1300, conta.Saldo);
    }
}
