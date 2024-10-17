using System.Numerics;

namespace NinjaShared
{
    public static class AttackableExtensions
    {
        public static float DistanceFrom(this IAttackable attacker, IAttackable target)
        {
            return Vector2.Distance(attacker.Position, target.Position);
        }

        public static IAttackable MoveTo(this IAttackable target, float x, float y)
        {
            target.Position = new Vector2(x, y);
            return target;
        }

    }

}
