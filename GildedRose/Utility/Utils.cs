using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;

namespace GildedRose.Utility
{
    /// <summary>
    /// This class is meant for the common methods, that are used more than once.
    /// </summary>
    public static class Utils
    {
        public static bool IsQualityGreaterThanFifty(int newQuality)
        {
            return newQuality > 50;
        }
        public static bool IsQualityNegative(int newQuality)
        {
            return newQuality < 0;
        }

        public static bool SellInIsNotPassed(Item item)
        {
            return item.SellIn > 0;
        }

        public static bool SellInIsPassed(Item item)
        {
            return item.SellIn < 1;
        }
    }
}
