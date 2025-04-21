using Transacoes.Core.Repositories;
using Transacoes.Core.Services;
using Transacoes.Core.Excecoes;

IContaDao dao = new ContaDao();
var service = new ContaService(dao);

Console.WriteLine("INÍCIO DAS OPERAÇÕES\n");

// Tentativa 1: Débito dentro do limite
try
{
    service.Debitar(1, 150);
    Console.WriteLine("Débito de R$150 realizado com sucesso!\n");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro no débito 1: {ex.Message}\n");
}

// Tentativa 2: Débito acima do saldo
try
{
    service.Debitar(1, 5000);
    Console.WriteLine("Débito de R$5000 realizado com sucesso!\n");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro no débito 2: {ex.Message}\n");
}

// Crédito para recuperar saldo
service.Creditar(1, 300);
Console.WriteLine("Crédito de R$300 realizado com sucesso!\n");

// Tentativa 3: Conta inexistente
try
{
    service.Debitar(99, 100); // Conta 99 não existe
}
catch (Exception ex)
{
    Console.WriteLine($"Erro no débito 3 (conta inexistente): {ex.Message}\n");
}

Console.WriteLine("FIM DAS OPERAÇÕES");
