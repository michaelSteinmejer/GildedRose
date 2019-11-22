using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Model
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public Item()
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + ", SellIn: " + SellIn + ", Quality: " + Quality;
        }
    }
}
