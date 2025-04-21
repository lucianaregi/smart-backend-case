using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingRuas.Core.Models
{
    public class Casa
    {
        public Rua Rua { get; set; }
        public int Numero { get; set; }
        public int TotalEleitores { get; set; }
    }
}
