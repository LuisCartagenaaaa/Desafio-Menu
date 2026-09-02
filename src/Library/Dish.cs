//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
}
public class Dish
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsVegetarian { get; set; }
    public Dish(string name, double price, bool veg)
    {
        Name = name;
        Price = price;
        IsVegetarian = veg;
    }
    public void MostrarTipo()
    {
        if (IsVegetarian == false)
        {
            Console.WriteLine("El plato no es vegetariano");
        }
        else
        {
            Console.WriteLine("El plato es vegetariano");
        }
    }
}
