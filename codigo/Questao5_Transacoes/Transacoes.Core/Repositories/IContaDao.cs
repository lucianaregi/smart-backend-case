using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transacoes.Core.Models;

namespace Transacoes.Core.Repositories
{
    public interface IContaDao
    {
        Conta BuscarConta(long idConta);
        void AtualizarConta(Conta conta);
    }
}
