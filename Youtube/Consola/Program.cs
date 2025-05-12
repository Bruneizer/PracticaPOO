using Biblioteca;

Console.WriteLine("ingrese titulo del video: ");
string titulo = Console.ReadLine();
Console.WriteLine("ingrese duracion del video: ");
int duracion = Convert.ToInt32(Console.ReadLine());
try
{
DateTime fecha;
Console.WriteLine("ingrese cantidad de likes: ");
int cantidadlikes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese cantidad de visualizaciones: ");
int cantidadvisualizaciones = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese fecha de subida: ");
string fechaTexto = Console.ReadLine();
if (!Validaciones.EsFechaValida(fechaTexto, out fecha))
{
    Console.WriteLine("Formato de fecha inválido.");
    return;
}


Video video= new Video(titulo,duracion,cantidadvisualizaciones,cantidadlikes,fecha);
video.Informar();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


