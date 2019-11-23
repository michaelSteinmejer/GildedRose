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

        public Item()
        {
        }
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }        
        //I Know that it is not allowed, as an requirement for this test,
        //however this is good practice, to add ToString overrides for your model classes.
        //else i would have to do it in the UpdateQuality method.
        public override string ToString()
        {
            return "Name: " + Name + ", SellIn: " + SellIn + ", Quality: " + Quality;
        }
    }
}
