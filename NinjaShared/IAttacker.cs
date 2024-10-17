using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NinjaShared
{
    public interface IAttacker : IAttackable //IAttacker interface can attack any implementation of the IAttackable interface
    {
        AttackResult Attack(IAttackable target);
    }
}
