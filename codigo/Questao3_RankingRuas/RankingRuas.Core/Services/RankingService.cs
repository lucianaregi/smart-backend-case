using RankingRuas.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RankingRuas.Core.Services
{
    public class RankingService
    {
        public List<Rua> RankRuasPorEleitores(List<Casa> casas)
        {
            if (casas == null || !casas.Any())
                return new List<Rua>();

            var eleitoresPorRua = new Dictionary<Rua, int>();

            foreach (var casa in casas)
            {
                if (casa.Rua != null)
                {
                    if (eleitoresPorRua.ContainsKey(casa.Rua))
                        eleitoresPorRua[casa.Rua] += casa.TotalEleitores;
                    else
                        eleitoresPorRua[casa.Rua] = casa.TotalEleitores;
                }
            }

            return eleitoresPorRua
                .OrderByDescending(par => par.Value)     
                .ThenBy(par => par.Key.Nome)             
                .Select(par => par.Key)
                .ToList();
        }
    }
}
