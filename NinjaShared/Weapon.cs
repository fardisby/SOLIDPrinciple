using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaShared
{
    public abstract class Weapon // for a ninja to attack another ninja, they must have access to weapons
    {
        public abstract float MinRanged { get; }
        public abstract float MaxRanged { get; }
        public virtual string Name => GetType().Name;

        public virtual bool CanHit(float distance)
            => distance >= MinRanged && distance <= MaxRanged;
    }
}
