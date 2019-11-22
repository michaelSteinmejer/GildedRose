using System;
using System.Collections.Generic;
using GildedRose.Controller;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose.TestingItems
{
    [TestClass]
    public class TestDefault
    {
        [TestMethod]
        public void TestRegularItem()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(19, Items2[0].Quality);
        }
        [TestMethod]
        public void TestRegularItemPassedSellIn()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20}
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(18, Items2[0].Quality);
        }
    }
}
