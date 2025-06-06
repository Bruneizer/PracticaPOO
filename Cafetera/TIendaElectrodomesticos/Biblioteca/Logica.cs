namespace Biblioteca;
// Agregar productos al inventario.
// Buscar productos por nombre o código.
// Eliminar productos del inventario.
// Mostrar el inventario completo (ordenado alfabéticamente por nombre)
// Vender productos.

public class Logica
{
     List<Electrodomestico> electrodomesticos1 = new List<Electrodomestico>();
     List<ItemVenta> Ventas = new List<ItemVenta>();
    public void AgregarElectrodomestico(Electrodomestico electrodomestico)
    {
        
        electrodomesticos1.Add(electrodomestico);
    }
    public void BuscarElectrodomesticoPorNombre(string nombre)
    {
        if (nombre == null)
        {
            Console.WriteLine("Electrodoméstico no encontrado.");
        }
        else
        {
        var resultado = electrodomesticos1.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Electrodoméstico encontrado: {resultado.Nombre}, Código: {resultado.CodigoAlfaNumerico}, Descripción: {resultado.Descripcion}, Stock: {resultado.Stock}, Precio Unitario: {resultado.PrecioUnitario:C}");
        }    
    }
    public void EliminarElectrodomestico(string codigoAlfaNumerico)
    {
        var electrodomestico = electrodomesticos1.FirstOrDefault(e => e.CodigoAlfaNumerico.Equals(codigoAlfaNumerico, StringComparison.OrdinalIgnoreCase));
        if (electrodomestico != null)
        {
            electrodomesticos1.Remove(electrodomestico);
            Console.WriteLine($"Electrodoméstico {electrodomestico.Nombre} eliminado del inventario.");
        }
        else
        {
            Console.WriteLine("Electrodoméstico no encontrado.");
        }
    }


}   
