using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;
using GildedRose.Utility;

namespace GildedRose.Controller
{
    class ItemConjured
    {
        /// <summary>
        /// This method handles the Conjured item, it i said that the Quality
        /// degrades twice as fast, than the default item.
        /// It still meets negative and greater than rules specified in the assignment.
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItem(Item item)
        {
            var newQuality = Utils.SellInIsNotPassed(item) ? item.Quality - 2 : item.Quality - 4;

            if (Utils.IsQualityNegative(newQuality))
            {
                newQuality = 0;
            }

            if (Utils.IsQualityGreaterThanFifty(newQuality))
            {
                newQuality = 50;
            }

            item.SellIn = item.SellIn - 1;
            item.Quality = newQuality;
        }
    }
}
