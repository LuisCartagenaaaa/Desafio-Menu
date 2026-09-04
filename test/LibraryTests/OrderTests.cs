using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Ucu.Poo.Restaurant.Tests
{
        public class OrderTests
    {
        [Test]
        public void GetTotal_BeforeAddDish_ReturnsZero()
        {
            Table table = new Table(1);
            table.Occupy();

            double expected = 0;
            double actual = table.GetTotal();

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetTotal_AfterAddDishes_ReturnsSumOfPrice()
        {
            Table table = new Table(1);
            table.Occupy();
            Dish salad = new Dish("Salad", 5.99, true);
            Dish burger = new Dish("Burger", 7.99, false);
            table.AddToOrder(salad);
            table.AddToOrder(burger);

            double expected = 5.99 + 7.99;
            double actual = table.GetTotal();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}