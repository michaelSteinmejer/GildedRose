using System;
using System.Collections.Generic;
using GildedRose.Controller;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose
{
    [TestClass]
    public class TestAgedBrie
    {
        [TestMethod]
        public void TestAgedBrieNormalIncreaseInQuality()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 0},
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(1, Items2[0].Quality);
        }
        [TestMethod]
        public void TestAgedBriePassedSellIn()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 0, Quality = 0},
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(2, Items2[0].Quality);
        }

        [TestMethod]
        public void TestAgedBriePassedMaxLimit()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 0, Quality = 51},
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(50, Items2[0].Quality);
        }
    }
}
