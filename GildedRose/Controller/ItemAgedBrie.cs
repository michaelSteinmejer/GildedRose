using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;
using GildedRose.Utility;

namespace GildedRose.Controller
{
    public static class ItemAgedBrie
    {
        /// <summary>
        /// This method handles that the Quality, always Increase when SellIn goes down,
        /// if the SellIn goes below 0 it increase by 2.
        /// It still meets negative and greater than rules specified in the assignment.
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItem(Item item)
        {
            var newQuality = Utils.SellInIsPassed(item) ? item.Quality + 2 : item.Quality + 1;

            if (Utils.IsQualityGreaterThanFifty(newQuality))
            {
                newQuality = 50;
            }
            item.SellIn = item.SellIn - 1;
            item.Quality = newQuality;
        }
    }
}
