﻿using NinjaShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NinjaBeforeOCP
{
    public class Ninja : IAttackable, IAttacker
    {
        private readonly Weapon _sword = new Sword();
        private readonly Weapon _shuriken = new Shuriken();

        public string Name { get; }

        public Vector2 Position { get; set ; }

        public Ninja(string name, Vector2? position = null)
        {
            Name = name;
            Position = position ?? Vector2.Zero;
        }

        public AttackResult Attack(IAttackable target)
        {
            var distance = this.DistanceFrom(target);
            if(_sword.CanHit(distance))
            {
                return new AttackResult(_sword, this, target);
            }
            else
            {
                return new AttackResult(_shuriken, this, target);
            }

        }
    }
}
