using System;
using System.Collections.Generic;
using GildedRose.Controller;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose.TestingItems
{
    [TestClass]
    public class TestBackstagePass
    {
        [TestMethod]
        public void TestBackstagePassSellInUnderFive()
        {
            List<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 20
                }
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(23, Items2[0].Quality);
        }
        [TestMethod]
        public void TestBackstagePassSellInUnderTen()
        {
            List<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 20
                }
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(22, Items2[0].Quality);
        }
        [TestMethod]
        public void TestBackstagePassDropsToQualityZero()
        {
            List<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 20
                }
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(0, Items2[0].Quality);
        }

        [TestMethod]
        public void TestBackstagePassReachedQualityLimit()
        {
            List<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 51
                }
            };

            IList<Item> Items2 = ItemUpdateHandler.UpdateQuality(1, Items);

            Assert.AreEqual(50, Items2[0].Quality);
        }
    }
}
