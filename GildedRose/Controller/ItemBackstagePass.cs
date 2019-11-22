using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;
using GildedRose.Utility;

namespace GildedRose.Controller
{
    public static class ItemBackstagePass
    {
        /// <summary>
        /// This method handles the various SellIn stages, with a increase in Quality.
        /// It still meets negative and greater than rules specified in the assignment.
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItem(Item item)
        {
            int newQuality;

            if (Utils.SellInIsPassed(item))
            {
                newQuality = 0;
            }
            else if (SellInIsInFiveOrLessDays(item))
            {
                newQuality = item.Quality + 3;
            }
            else if (SellInIsInTenOrLessDays(item))
            {
                newQuality = item.Quality + 2;
            }
            else
            {
                newQuality = item.Quality + 1;
            }

            if (Utils.IsQualityGreaterThanFifty(newQuality))
            {
                newQuality = 50;
            }

            item.SellIn = item.SellIn - 1;
            item.Quality = newQuality;
        }

        private static bool SellInIsInTenOrLessDays(Item item)
        {
            return item.SellIn < 11;
        }

        private static bool SellInIsInFiveOrLessDays(Item item)
        {
            return item.SellIn < 6;
        }
    }
}
