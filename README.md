<!-- markdownlint-disable MD033 -->
<!-- markdownlint-disable-next-line MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Programación II

# Desafío menú #1: Restaurante simple

## Objetivo

Completar la implementación en C# las clases indicadas a continuación, con sus
responsabilidades y colaboraciones, también indicadas a continuación.

<!--

Cada clase debe ser agregada por un estudiante diferente y deben trabajar en
ramas diferentes.

## Pasos

1. Uno de los estudiantes del equipo crea un repositorio privado a partir de
este repositorio plantilla haciendo clic en el botón `Use this template` y luego
en el comando `Create new repository.

2. El estudiante que creó el repositorio agrega a los demás integrantes del
equipo haciendo clic en `Settings`, `Collaborators and Teams`, `Add people` para
cada uno de los miembros del equipo, usando sus nombres de usuario.

3. Todos clonan el repositorio creado a sus equipos.

4. Todos crean una rama con el nombre que quieran, la única condición es que
deben ser diferentes para cada miembro del equipo.

5. Distribuyan las siguientes clases entre los miembros del equipo. Cada miembro
implementa una clase diferente.

6. El código no va a funcionar hasta que integren el trabajo en la rama `main`,
por lo que deberán unir los cambios con frecuencia.
-->

> [!NOTE]
>
> Crea tu propio repositorio a partir de esta plantilla y clona ese repositorio
> en tu equipo.

<!-- Intentionally left blank -->

> [!IMPORTANT]
>
> Para compilar el código en Visual Studio Code ejecuten el comando `Run Build
> Task...` del menú `Terminal` y elijan `dotnet: build`.

<!-- Intentionally left blank -->

> [!TIP]
>
> Aunque todavía no vamos a ver cómo escribir ni ejecutar casos de prueba, este
> repositorio usa casos de prueba para que puedan comprobar su solución.
>
> Los casos de prueba están comentados para que la solución compile sin errores.
> Quita los comentarios que hay en
> [DishTests.cs](./test/LibraryTests/DishTests.cs),
> [MenuTests.cs](./test/LibraryTests/MenuTests.cs),
> [TableTests.cs](./test/LibraryTests/TableTests.cs) y
> [WaiterTests.cs](./test/LibraryTests/WaiterTests.cs).
>
> Una vez que ya no haya errores de compilación, ejecuta los casos de
> prueba usando el comando `Testing`  del menú `View` para mostrar el explorador
> de tests, y luego, haz como aparece a continuación:
>
> ![](/assets/RunTests.gif)

## Clases a implementar

A continuación la descripción de las clases, sus responsabilidades de hacer y de
conocer, y sus colaboraciones.

### 1. **Clase `Dish`**

Representa un platillo individual en el menú del restaurante.

<table>
  <tr>
    <th colspan="2">
      Dish
    </th>
  </tr>
  <tr>
    <td>
      Conocer el nombre del platillo<br>
      Conocer el precio del platillo<br>
      Conoce si el platillo es vegetariano o no<br>
    </td>
    <td>
    </td>
  </tr>
</table>

* Responsabilidades de conocer:
  * **Name**: Conocer el nombre del platillo.
  * **Price**: Conocer el precio del platillo.
  * **IsVegetarian**: Conocer si el platillo es vegetariano o no.

* No tiene responsabilidades de hacer.

* No tiene colaboradores.

> [!IMPORTANT]
> Debe ser posible crear una instancia de `Dish` e inicializar sus propiedades
> en una sola operación.

Aquí está el código provisto de la clase [`Dish`](./src/Library/Dish.cs).

### 2. **Clase `Menu`**

Representa el conjunto de platillos disponibles en el restaurante.

<table>
  <tr>
    <th colspan="2">
      Menu
    </th>
  </tr>
  <tr>
    <td>
      Conocer la lista de platillos disponibles en el restaurante<br>
      Agregar un platillo a la lista de platillos del menú<br>
      Eliminar un platillo de la lista del menú<br>
      Buscar y devolver un platillo específico del menú basado en su nombre<br>
    </td>
    <td>
      Dish
    </td>
  </tr>
</table>

* Responsabilidades de conocer:
  * `dishes`: Conocer la lista de platillos disponibles en el restaurante;
    esta responsabilidad está ya implementada con la variable de instancia
    `dishes` en el código provisto.

* Responsabilidades de hacer
  * `AddDish(Dish)`: Agregar un platillo a la lista de platillos del menú.
  * `RemoveDish(Dish)`: Eliminar un platillo de la lista del menú.
  * `Dish GetDishByName(string)`: Buscar y devolver un platillo específico del
    menú basado en su nombre; retorna `null` si no encuentra en platillo.

* Colaboradores
  * Dish

> [!TIP]
> Puedes acceder al i-ésimo elemento de la variable de instancia `dishes` con
> `dishes[i]` y las estructuras de repetición condicional que consideres
> apropiadas. También puedes recorrer los platillos en esa variable de instancia
> con la estructura repetitiva condicional `foreach`.

Aquí está el código provisto de la clase [`Menu`](./src/Library/Menu.cs).

### 3. **Clase [`Table`](./src/Library/Table.cs)**

Representa una mesa en el restaurante.

<table>
  <tr>
    <th colspan="2">
      Table
    </th>
  </tr>
  <tr>
    <td>
      Conocer el número identificador de la mesa<br>
      Conocer si la mesa está ocupada o no<br>
      Conocer la lista de platillos que han sido ordenados en la mesa<br>
      Marcar la mesa como ocupada<br>
      Liberar la mesa y vaciar la lista de pedidos<br>
      Agregar un platillo a los que han sido ordenados en la mesa<br>
      Determinar si la mesa tiene pedidos o no<br>
    </td>
    <td>
      Dish
    </td>
  </tr>
</table>

* Responsabilidades de conocer:
  * `Number`: Conocer el número identificador de la mesa.
  * `IsOccupied`: Conocer si la mesa está ocupada o no.
  * `Order`: Conocer la lista de platillos que han sido pedidos en la mesa;
    esta responsabilidad está ya implementada con la variable de instancia
    `order` en el código provisto.

* Responsabilidades de hacer:
  * `Occupy()`: Marcar la mesa como ocupada.
  * `Free()`: Liberar la mesa y vaciar la lista de pedidos.
  * `AddToOrder(Dish)`: Agregar un platillo a la lista de pedidos.
  * `bool HasOrders()`: Determinar si la mesa tiene pedidos o no; retorna `true`
    si los tiene y `false` en caso contrario.

* Colaboradores:
  * Dish

> [!TIP]
> El método `Clear()` de la clase `ArrayList` vacía la lista.

<br>

> [!IMPORTANT]
> Debe ser posible crear una instancia de `Table` e inicializar sus propiedades
> en una sola operación.

Aquí está el código provisto de la clase [`Table`](./src/Library/Table.cs).

### 4. **Clase `Waiter`**

Representa un mozo en el restaurante, encargado de atender mesas.

<table>
  <tr>
    <th colspan="2">
      Waiter
    </th>
  </tr>
  <tr>
    <td>
      Conocer el nombre del mozo<br>
      Conocer las mesas asignadas al mozo<br>
      Asignar una mesa al mozo<br>
      Tomar un pedido para una mesa específica y agregar el platillo a la orden
      de esa mesa<br>
    </td>
    <td>
      Dish<br>
      Table<br>
    </td>
  </tr>
</table>

* Responsabilidades de conocer:
  * `Name`: Conocer el nombre del mozo.
  * `assignedTables`: Conocer las mesas asignadas al mozo; esta responsabilidad
    está ya implementada con la variable de instancia `assignedTables` en el
    código provisto.

* Responsabilidades de hacer:
  * `AssignTable(Table)`: Asignar una mesa al mozo.
  * `TakeOrder(Table, Dish)`: Tomar un pedido para una mesa específica
    y agregar el platillo a la orden de esa mesa.

* Colaboradores:
  * Dish
  * Table

> [!IMPORTANT]
> Debe ser posible crear una instancia de `Waiter` e inicializar sus propiedades
> en una sola operación.

Aquí está el código provisto de la clase [`Waiter`](./src/Library/Waiter.cs).

## Uso de ![GitHub Copilot](https://img.shields.io/badge/GitHub%20Copilot-000?logo=githubcopilot&logoColor=fff)

Es posible usar GitHub Copilot en este repositorio. Consulta [cómo usar Copilot
para aprender](./COPILOT.md).
