using System.Data;
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
// List<Empleado> empleado = new List<Empleado>();
// Console.WriteLine("Nombre: ");
// string nombre = Console.ReadLine();
// while(nombre != "")
// {
// Console.WriteLine("Email: ");
// string email = Console.ReadLine();
// Console.WriteLine("Salario: ");
// decimal salario = Convert.ToDecimal(Console.ReadLine());
// Empleado empleado1 = new Empleado
// {
// Nombre = nombre,
// Email = email,
// Salario = salario
// };
// empleado.Add(empleado1);
// Console.WriteLine("Nombre: ");
// nombre = Console.ReadLine();

// }
// foreach(var emp in empleado)
// {
//     Console.WriteLine($"Nombre: {emp.Nombre}");
//     Console.WriteLine($"Email: {emp.Email}");
//     Console.WriteLine($"Salario: {emp.Salario}");
//     Console.WriteLine("----------------------------------------");
// }
// // Any().El método Any() pertenece a LINQ y se usa para verificar si una colección contiene al menos un elemento.
// // devuelve true si hay al menos un empleado, y false si está vacía
// // Esto evita errores si intentás buscar el máximo en una lista vacía.
// if(empleado.Any())
// {
// var salarioMaximo = empleado
//         .OrderByDescending(e => e.Salario)
//         .First();
// Console.WriteLine($"El empleado {salarioMaximo.Nombre} tiene el salario mas alto con {salarioMaximo.Salario}");
// // OrderByDescending(e => e.Salario)ordena la lista de empleados de mayor a menor salario.
// //.First(): toma el primer empleado de esa lista ordenada (es decir, el que tiene el salario más alto).
// //empleadoConMayorSalario: es una variable que guarda ese empleado.
// }

