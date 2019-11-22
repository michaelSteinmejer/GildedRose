using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;

namespace GildedRose.Controller
{
    public static class ItemSulfuras
    {
        /// <summary>
        /// This method insures that this item is "not to be touched",
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItem(Item item)
        {
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
            item.Name = item.Name;

        }
    }
}
