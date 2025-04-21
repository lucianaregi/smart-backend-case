using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TratamentoErros.Core.Exceptions;

namespace TratamentoErros.Core.Services
{
    public class ValidadorCpfService
    {
        public void Validar(string cpf)
        {
            cpf = Regex.Replace(cpf ?? "", @"[^\d]", "");

            if (cpf.Length != 11 || TodosDigitosIguais(cpf) || !DigitosVerificadoresValidos(cpf))
            {
                throw new CpfInvalidoException(cpf);
            }
        }

        private bool TodosDigitosIguais(string cpf)
        {
            return cpf.All(d => d == cpf[0]);
        }

        private bool DigitosVerificadoresValidos(string cpf)
        {
            var numeros = cpf.Select(c => int.Parse(c.ToString())).ToArray();

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += numeros[i] * (10 - i);
            int digito1 = soma % 11 < 2 ? 0 : 11 - (soma % 11);
            if (numeros[9] != digito1) return false;
           
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += numeros[i] * (11 - i);
            int digito2 = soma % 11 < 2 ? 0 : 11 - (soma % 11);
            return numeros[10] == digito2;
        }
    }
}
