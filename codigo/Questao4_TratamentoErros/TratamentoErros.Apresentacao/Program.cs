using TratamentoErros.Core.Exceptions;
using TratamentoErros.Core.Services;

var validador = new ValidadorCpfService();

var cpfsParaTestar = new List<string>
{
    "123.456.789-00", 
    "11111111111",    
    "39053344705",    
    "529.982.247-25", 
    "abcdefghijk",    
    "1234567890",     
    ""                
};

foreach (var cpf in cpfsParaTestar)
{
    try
    {
        Console.WriteLine($"Validando CPF: {cpf}");
        validador.Validar(cpf);
        Console.WriteLine("CPF válido\n");
    }
    catch (CpfInvalidoException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}\n");
    }
}
