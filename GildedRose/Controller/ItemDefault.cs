using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;
using GildedRose.Utility;

namespace GildedRose.Controller
{
    class ItemDefault
    {
        /// <summary>
        /// This method handles the default item, if there is
        /// no special criteria, the item will be updated here.
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItem(Item item)
        {
            var newQuality = Utils.SellInIsNotPassed(item) ? item.Quality - 1 : item.Quality - 2;

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
