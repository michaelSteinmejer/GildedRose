using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Model;

namespace GildedRose.Controller
{
    public static class ItemUpdateHandler
    {
        /// <summary>
        /// This method loops through the chosen amount of days,
        /// and updates each item. This method is also responsible,
        /// for displaying the updated data 
        /// </summary>
        /// <param name="days"></param>
        /// <param name="Items"></param>
        public static List<Item> UpdateQuality(int days, List<Item> Items)
        {
            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("|---this is day: " + (i + 1) + "---|");

                foreach (Item item in Items)
                {
                    UpdateItemQuality(item);
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
            return Items;
        }
        /// <summary>
        /// This method is responsible for choosing which case,
        /// is assigned to the right item.
        /// I chose i switch case because of performance.
        /// </summary>
        /// <param name="item"></param>
        public static void UpdateItemQuality(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    ItemAgedBrie.UpdateItem(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    ItemBackstagePass.UpdateItem(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    ItemSulfuras.UpdateItem(item);
                    break;
                case "Conjured Mana Cake":
                    ItemConjured.UpdateItem(item);
                    break;
                default:
                    ItemDefault.UpdateItem(item);
                    break;
            }
        }
    }
}
