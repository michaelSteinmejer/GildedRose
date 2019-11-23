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
            string name = ConjuredItems(item.Name);
            switch (name)
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
                case "Conjured":
                    ItemConjured.UpdateItem(item);
                    break;
                default:
                    ItemDefault.UpdateItem(item);
                    break;
            }
        }

        /// <summary>
        /// The rules provided says: We have recently signed a supplier of conjured items.
        /// So in fact, there can be more than one type of Conjured items.
        /// Which means i need to handle all items, where the name contains Conjured, without altering the items name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConjuredItems(string name)
        {
            return name.Contains("Conjured") ? "Conjured" : name;
        }
    }
}
