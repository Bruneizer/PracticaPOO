// Agregar productos al inventario.
// Buscar productos por nombre o código.
// Eliminar productos del inventario.
// Mostrar el inventario completo (ordenado alfabéticamente por nombre)
// Vender productos.
using Biblioteca;
using System;
Logica logica = new Logica();
bool activo = true;
while(activo)
{
    Console.WriteLine("Presione 1 para agregar un electrodoméstico");
    Console.WriteLine("Presione 2 para buscar un electrodoméstico por nombre o código");
    Console.WriteLine("Presione 3 para eliminar un electrodoméstico del inventario");
    Console.WriteLine("Presione 4 para mostrar el inventario completo (ordenado alfabéticamente por nombre)");
    Console.WriteLine("Presione 5 para vender un electrodoméstico");
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            // Lógica para agregar un electrodoméstico
            Console.WriteLine("Nombre del electrodoméstico:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Código alfanumérico del electrodoméstico:");
            string codigoAlfaNumerico = Console.ReadLine();
            Console.WriteLine("Descripción del electrodoméstico:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Stock del electrodoméstico:");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio unitario del electrodoméstico:");
            decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
            Electrodomestico electrodomesticos1 = new Electrodomestico(nombre, codigoAlfaNumerico, descripcion, stock, precioUnitario);
            logica.AgregarElectrodomestico(electrodomesticos1);
            Console.WriteLine($"Electrodoméstico {electrodomesticos1.Nombre} agregado al inventario.");
            break;
        case 2:
            // Lógica para buscar un electrodoméstico por nombre o código
            Console.WriteLine("Buscar un electrodoméstico por nombre: ");
            string nombreBuscar = Console.ReadLine();
            logica.BuscarElectrodomesticoPorNombre(nombreBuscar);
            Console.WriteLine($"Resultados de la búsqueda para {nombreBuscar}:");
            break;
        case 3:
            // Lógica para eliminar un electrodoméstico del inventario
            Console.WriteLine("Codigo alfanumérico del electrodoméstico a eliminar:");
            string codigoEliminar = Console.ReadLine();
            logica.EliminarElectrodomestico(codigoEliminar);
            Console.WriteLine($"Electrodoméstico con código {codigoEliminar} eliminado del inventario.");
            break;
        case 4:
            // Lógica para mostrar el inventario completo
            Console.WriteLine("Mostrar el inventario completo (ordenado alfabéticamente por nombre)");
            break;
        case 5:
            // Lógica para vender un electrodoméstico
            Console.WriteLine("Vender un electrodoméstico");
            break;
            Console.WriteLine("Opción no válida, intente nuevamente.");
            break;
}
    // activo = false; // Para salir del bucle después de una opción
}