using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoErros.Core.Exceptions
{
   public class CpfInvalidoException : Exception
{
    public CpfInvalidoException(string cpf)
        : base($"O CPF '{cpf}' é inválido.") { }
}
}
