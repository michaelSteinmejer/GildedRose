using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Controller;
using GildedRose.Model;

namespace GildedRose
{
    class Program
    {
        public static List<Item> Items = new List<Item>
        {
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 10}
        };
        private static void Main(string[] args)
        {

            // This where the method get executed.
            // Add the number of days and the desired list of items, to view changes overtime.
            ItemUpdateHandler.UpdateQuality(5, Items);

            System.Console.ReadKey();

        }
    }
}
