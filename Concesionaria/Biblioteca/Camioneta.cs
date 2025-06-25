
// Una concesionaria de vehículos desea una aplicación para administrar las ventas de sus productos y clasificarlos por tipo. Todos los autos tienen número de serie del motor, marca, año y precio. De todos los modelos de vehículos que se comercializan tienen variantes a combustión o eléctricos.

// Los vehículos se clasifican en autos compactos, autos de lujo, deportivos, camionetas y familiar, etc. Para los autos familiares, también es importante almacenar la cantidad de pasajeros; mientras que para las camionetas se debe controlar la capacidad de carga en kgs. y la cantidad de ejes. 

// Se debe poder consultar el kilometraje y el consumo de cada vehículo. Si el vehículo es de combustión, si es un auto su consumo es de 1 litro por cada 13 km recorridos. Para las camionetas el consumo por litro es 10 km. En el caso de los vehículos eléctricos el consumo por kilómetro es de 20 kWh aproximadamente.

// La aplicación debe informar el consumo del vehículo en base a una cantidad de kilómetros recorridos y su tipo (si es de combustión o eléctrico).

// Realizar: 
// Aplicar el concepto de herencia en la solución
// Diagrama de clases modelando la situación planteada
// Confección de los proyectos de biblioteca y consola. En el proyecto de consola crear los objetos con datos simulados (no es necesarios ingresarlos por teclado)
namespace Biblioteca;
public class Camioneta : AutoSupremo
{
    public decimal CapacidadDeCarga { get; set; }

    public Camioneta(string numeroSerieMotor, string marca,int anio, decimal precio,double kilometraje,decimal capacidadDeCarga, Motor motor ) 
    : base(numeroSerieMotor, marca, anio, precio,kilometraje,motor)
    {
        CapacidadDeCarga = CapacidadDeCarga;

    }
    
}