using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NinjaShared
{
    public class Sword : Weapon
    {
        public override float MinRanged { get; } = 0;
        public override float MaxRanged { get; } = Vector2.Distance(Vector2.Zero, Vector2.One);
    }
}
