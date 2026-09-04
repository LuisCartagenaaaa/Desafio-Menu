using NUnit.Framework;
using System.Collections;

namespace Ucu.Poo.Restaurant.Tests
{
    [TestFixture]
    public class TakeawayOrderTests
    {
        [Test]
        public void GetTotal_ReturnsCorrectSum()
        {
            ArrayList dishes = new ArrayList();
            dishes.Add(new Dish("Milanesa", 350.0, false));
            // La coca es vegana? jajajajjajaja
            dishes.Add(new Dish("Refresco", 100.0, true));
            Order innerOrder = new Order(dishes);
            TakeAwayOrder takeawayOrder = new TakeAwayOrder("Luis", innerOrder);
            double total = takeawayOrder.GetTotal();
            Assert.That(total, Is.EqualTo(450.0));
        }
    }
}