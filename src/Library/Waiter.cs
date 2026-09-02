//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;
using System.Dynamic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private ArrayList assignedTables = new ArrayList();
        public string Name {get; set;}
        public ArrayList AssignedTables
        {
            get { return this.assignedTables;}
        }
        public Waiter(string name)
        {
            this.Name = name;
        }
        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}