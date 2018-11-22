using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNote.WFRP
{
    static class CoinCalculator
    {
        public const int SILVERS_IN_GOLD = 20;
        public const int PENNIES_IN_SILVER = 12;

        static CoinCalculator()
        {

        }

        public static decimal GoldToSilver(decimal gold)
        {
            return gold * SILVERS_IN_GOLD;
        }

        public static decimal GoldToPennies(decimal gold)
        {
            return gold * SILVERS_IN_GOLD * PENNIES_IN_SILVER;
        }
        public static decimal SilverToGold(decimal silver)
        {
            return silver / SILVERS_IN_GOLD;
        }
        public static decimal SilverToPennies(decimal silver)
        {
            return silver * PENNIES_IN_SILVER;
        }

        public static decimal PenniesToGold(decimal pennies)
        {
            return pennies / PENNIES_IN_SILVER / SILVERS_IN_GOLD;
        }

        public static decimal PenniesToSilver(decimal pennies)
        {
            return pennies / PENNIES_IN_SILVER;
        }
    }
}
