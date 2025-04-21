using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingRuas.Core.Models
{
    public class Rua : IEquatable<Rua>
    {
        public string Cep { get; set; }
        public string Nome { get; set; }

        public bool Equals(Rua other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Cep == other.Cep;
        }

        public override bool Equals(object obj) => Equals(obj as Rua);
        public override int GetHashCode() => Cep?.GetHashCode() ?? 0;

        public static bool operator ==(Rua left, Rua right) => Equals(left, right);
        public static bool operator !=(Rua left, Rua right) => !Equals(left, right);
    }
}
