using System;
using System.CodeDom;
using System.Collections.Generic;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using GildedRose.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGildedRose.TestingItems
{
    [TestClass]
    public class TestUpdateQuality
    {   /// <summary>
        ///In this test method, i have implemented the dependency ApprovalTest.
        ///It makes it easy, to test many scenarios and get the full CodeCoverage.
        ///the idea is that VerifyAllCombination passes arguments to a method,
        ///until all combinations are met. It then generates two text files Received.txt
        ///and approved.txt, you then approve the cases in the Received.txt by
        ///copying it to approved.txt.
        /// </summary>
        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestingUpdateQuality(){

            CombinationApprovals.VerifyAllCombinations(DoUpdateQuality,
                new string[] {
                    "Aged Brie",
                    "Elixir of the Mongoose",
                    "Sulfuras, Hand of Ragnaros",
                    "+5 Dexterity Vest",
                    "Backstage passes to a TAFKAL80ETC concert",
                    "Conjured Mana Cake"
                },
                new int[] { -1, 0, 5, 10, 15, 25 },
                new int[] { 0, 1, 10, 20, 49, 55 }

                );
        }

        private static string DoUpdateQuality(string name, int sellIn, int quality)
        {
            var items = new List<Item>{new Item{Name=name,SellIn=sellIn,Quality=quality} };
             GildedRose.Controller.ItemUpdateHandler.UpdateQuality(1, items);
            return items[0].ToString();
        }
    }
}
