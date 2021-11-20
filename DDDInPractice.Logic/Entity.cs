using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    public abstract class Entity
    {
        public long Id { get; private set; }
        public override bool Equals(object obj)
        {
            Entity other = obj as Entity;

            if (ReferenceEquals(other, null))
                return false;

            return Id == other.Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
