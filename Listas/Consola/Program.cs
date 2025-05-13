using Biblioteca;
//Escribir un programa en donde el usuario ingrese asignaturas de un curso 
//(por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista 
//y la informe por pantalla en orden alfabético.
// Console.Write("Ingrese su asignatura: ");
// string asignatura = Console.ReadLine();
// List<string> asignaturas = new List<string>();
// while(asignatura != "")
// {
//     asignaturas.Add(asignatura);
//     Console.Write("Asignatura: ");
//     asignatura = Console.ReadLine();
// }
// OrderBy = filtra de abajo hacia arriba las asignaturas en orden alfabetico = a,b,c,etc... los numeros de mayor a menor = 1,2,3,25,30,etc
// OrderByDescending = filtra de arriba hacia abajo las asignaturas = c,b,a,etc...... los numeros de mayor a menor = 50,46,25,10,15,3,2,1
// var asignaturasOrdenadas =  asignaturas.OrderBy(asignatura => asignatura);
// var primeraAsignatura = asignatura.First();
// var ultimaAsignatura = asignatura.Last();
// foreach recorre elementos de una lista
// foreach(var asignaturass in asignaturasOrdenadas)
// {
// Console.WriteLine(asignaturass);
// }



// Ejercicio 2
// Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y su calificación asociada. Informar por pantalla las asignaturas con sus respectivas notas todo ordenado de forma descendente por nota.
// List<Calificacion> calificaciones = new List<Calificacion>();
// Console.WriteLine("Ingrese Materia: ");
// string asignatura = Console.ReadLine();
// while(asignatura != "")
// {
// Console.WriteLine("Nota");
// int nota = Convert.ToInt32(Console.ReadLine()); 

// Calificacion calificacion = new Calificacion
// {
//     Asignatura = asignatura,
//     Nota = nota
// };
// calificaciones.Add(calificacion);
// Console.WriteLine("Ingrese Materia: ");
// asignatura = Console.ReadLine();
// }
// foreach(var calificacion1 in calificaciones)
// {
// Console.WriteLine($"Calificacion: {calificacion1.Asignatura}");
// Console.WriteLine($"Nota {calificacion1.Nota}");
// }
// Ejercicio 3
// Escribir un programa que se ingrese el nombre, email y salario de empleados en una fábrica. Informar por pantalla el nombre del empleado con mayor salario y el listado de empleados con todos sus datos ordenado alfabéticamente por nombre de empleado.
Console.WriteLine("Nombre: ");
string Nombre = Console.ReadLine();
Console.WriteLine("Email: ");
string Email = Console.ReadLine();
Console.WriteLine("Salario: ");
decimal Salario = Convert.ToInt32(Console.ReadLine());
List<Empleado> empleado = new List<Empleado>();
while(Nombre != "")
{


}

