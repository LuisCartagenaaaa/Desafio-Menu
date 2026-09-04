//------------------------------------------------------------------------------
// <copyright file="Table.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number {get; set;}
        public bool IsOccupied {get; set;}
        public ArrayList Order
        {
            get
            {
                return this.order;
            }
        }
        public void Occupy()
        {
            this.IsOccupied = true;
        }
        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear(); 
        }
        public void AddToOrder (Dish dish)
        {
            this.order.Add(dish);
        }
        public Table(int number, bool isOccupied = false)
        {
            this.Number = number;
            this.IsOccupied = isOccupied;
        }
        private ArrayList order = new ArrayList();

        public double GetTotal()
        {
            Order currentOrder = new Order(this.order);
            return currentOrder.GetTotal();
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}