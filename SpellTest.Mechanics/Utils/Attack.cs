using System;

namespace SpellTest.Mechanics
{
    public static class Attack
    {
        public static double DamageMultiplier(double defense)
        {
            return 1.0 - ((0.052 * defense) / (0.9 + (0.048 * defense)));
        }

        public static double DamageDealt(double damage, double defense)
        {
            return damage * DamageMultiplier(defense);
        }
}
