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
        private ArrayList order = new ArrayList();

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}