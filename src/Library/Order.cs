using System.Collections;
using System.Collections.Concurrent;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Order
    {
        private readonly ArrayList order;

        public Order(ArrayList order)
        {
            this.order = order;
        }
        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in this.order)
            {
                total = total + dish.Price;
            }
            return total;
        }
    }
}