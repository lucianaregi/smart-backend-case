using Xunit;
using TratamentoErros.Core.Services;
using TratamentoErros.Core.Exceptions;

namespace Questao4.Tests;

public class ValidadorCpfServiceTests
{
    [Fact]
    public void DeveValidarCpfValido()
    {
        var service = new ValidadorCpfService();
        var cpf = "12345678909"; 
        var ex = Record.Exception(() => service.Validar(cpf));
        Assert.Null(ex); 
    }

    [Fact]
    public void DeveLancarExcecao_ParaCpfInvalido()
    {
        var service = new ValidadorCpfService();
        var cpf = "11111111111"; 

        Assert.Throws<CpfInvalidoException>(() => service.Validar(cpf));
    }
}
