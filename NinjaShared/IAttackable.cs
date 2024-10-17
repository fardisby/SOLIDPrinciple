using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NinjaShared
{
    public interface IAttackable
    {
        string Name { get; }
        Vector2 Position { get; set; }
    }
}
