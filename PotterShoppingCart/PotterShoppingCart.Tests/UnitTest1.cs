using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class ShoppingCartTest
    {
        //Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        //Given 第一集買了 1 本
        //And 第二集買了 0 本
        //And 第三集買了 0 本
        //And 第四集買了 0 本
        //And 第五集買了 0 本
        //When 結帳
        //Then 價格應為 100 元
        [TestMethod]
        public void GetPriceTest_Volume1x1_Volume2x0_Volume3x0_Volume4x0_Volume5x0_ShouldBe_100()
        {
            // arrange
            ShoppingCart target = new ShoppingCart();
            target.AddBook(new Book("PoterVolume1"), 1);

            int expectedPrice = 100;

            // act
            int actualPrice = target.GetPrice();
 
            // assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
