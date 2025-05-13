//Escribir un programa en donde el usuario ingrese asignaturas de un curso 
//(por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista 
//y la informe por pantalla en orden alfabético.
Console.Write("Ingrese su asignatura: ");
string asignatura = Console.ReadLine();

List<string> asignaturas = new List<string>();

while(asignatura != "")
{
    asignaturas.Add(asignatura);
    Console.Write("Asignatura: ");
    asignatura = Console.ReadLine();
}
// OrderBy = filtra de abajo hacia arriba las asignaturas en orden alfabetico = a,b,c,etc... los numeros de mayor a menor = 1,2,3,25,30,etc
// OrderByDescending = filtra de arriba hacia abajo las asignaturas = c,b,a,etc...... los numeros de mayor a menor = 50,46,25,10,15,3,2,1
var asignaturasOrdenadas =  asignaturas.OrderBy(asignatura => asignatura);
var primeraAsignatura = asignatura.First();
var ultimaAsignatura = asignatura.Last();





// foreach recorre elementos de una lista
foreach(var asignaturass in asignaturasOrdenadas)
{
Console.WriteLine(asignaturass);
}
