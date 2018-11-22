using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNote.WFRP
{
    static class XPCalculator
    {
        readonly static int[] CharacteristicCost = { 25, 30, 40, 50, 70, 90, 120, 150, 190, 230, 280, 330, 390, 450, 520 };

        readonly static int[] SkillCost = { 10, 15, 20, 30, 40, 60, 80, 110, 140, 180, 220, 270, 320, 380, 440 };

        static private int AccessCharArray(int index)
        {
            if (index >= CharacteristicCost.Length)
            {
                return 520;
            }
            else
                return CharacteristicCost[index];
        }

        static private int AccessSkillArray(int index)
        {
            if (index >= CharacteristicCost.Length)
            {
                return 440;
            }
            else
                return CharacteristicCost[index];
        }

        public static int CalculateCharXPNeeded(int startAdvance, int targetAdvance)
        {
            if (startAdvance >= targetAdvance)
                return 0;


            return AccessCharArray(startAdvance/5) + CalculateCharXPNeeded(startAdvance + 1, targetAdvance);
        }

        public static int CalculateSkillXPNeeded(int startAdvance, int targetAdvance)
        {
            if (startAdvance >= targetAdvance)
                return 0;
            return AccessSkillArray(startAdvance/5) + CalculateSkillXPNeeded(startAdvance + 1, targetAdvance);
        }

        public static int CalculateCharAdvancesPossible(int startAdvance, int XP)
        {
            if (XP < AccessCharArray(startAdvance / 5))
                return 0;
            return 1 + CalculateCharAdvancesPossible(startAdvance + 1, XP - CharacteristicCost[startAdvance / 5]);
        }

        public static int CalculateSkillAdvancesPossible(int startAdvance, int XP)
        {
            if (XP < AccessSkillArray(startAdvance / 5))
                return 0;
            return 1 + CalculateSkillAdvancesPossible(startAdvance + 1, XP - SkillCost[startAdvance / 5]);
        }
    }
}
