using System;
using System.Collections.Generic;
using GildedRose.Controller;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose.TestingItems
{
    [TestClass]
    public class TestConjured
    {
        [TestMethod]
        public void TestConjuredNormalDegradeInQuality()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 10}
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(8, Items2[0].Quality);
        }
        [TestMethod]
        public void TestConjuredPassedSellIn()
        {
            List<Item> Items = new List<Item>
            {
                new Item {Name = "Conjured Mana Cake", SellIn = 0, Quality = 10}
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(6, Items2[0].Quality);
        }
    }
}
