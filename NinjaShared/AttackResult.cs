using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaShared
{
    public class AttackResult //The AttackResult class is responsible for keeping a hold on the result of an attack.
    {
        public string Weapon { get; }
        public string Attacker { get; }
        public string Target { get; }
        public bool Succeeded { get; }
        public float Distance { get; }

        public AttackResult(Weapon weapon, IAttacker attacker, IAttackable target)
        {
            Weapon = $"{weapon.Name} (Min: {weapon.MinRanged}, Max: {weapon.
MaxRanged})";
            Attacker = $"{attacker.Name} (Position: {attacker.Position})";
            Target = $"{target.Name} (Position: {target.Position})";
            Distance = attacker.DistanceFrom(target);
            Succeeded = weapon.CanHit(Distance);
        }
    }

}
