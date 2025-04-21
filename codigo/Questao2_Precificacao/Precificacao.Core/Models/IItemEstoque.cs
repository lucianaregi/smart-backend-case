using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precificacao.Core.Models
{
    public interface IItemEstoque
    {
        double CalcularCusto();
        string Nome { get; }
    }
}
