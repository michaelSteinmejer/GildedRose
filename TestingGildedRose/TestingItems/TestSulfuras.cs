using System;
using System.Collections.Generic;
using GildedRose.Controller;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose.TestingItems
{
    [TestClass]
    public class TestSulfuras
    {
        [TestMethod]
        public void TestSulfurasIsNotToBeChanged()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 90},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(80, Items2[0].Quality);
            Assert.AreEqual(80, Items2[1].Quality);
            Assert.AreEqual(90, Items2[2].Quality);
            Assert.AreEqual(80, Items2[3].Quality);
        }
    }
}
