namespace Biblioteca;

public class Video
{
public string Titulo {get; set;}
public int Duracion {get; set;}
public int CantidadVisualizaciones {get; set;} 
public int CantidadLikes {get; set;}
public DateTime Fecha  {get; set;}
public Video(string titulo, int duracion, int cantidadvisualizaciones, int cantidadlikes, DateTime fecha)
{
if(cantidadvisualizaciones < 0 || cantidadlikes < 0 )
{
    throw new ArgumentException("Los valores de vistas o likes no pueden ser negativos");
}
    Titulo = titulo;
    Duracion = duracion;
    CantidadVisualizaciones = cantidadvisualizaciones;
    CantidadLikes = cantidadlikes;
    Fecha = fecha;

}

public void Informar()
{
    Console.WriteLine($"El título es {Titulo}, duración: {Duracion}, likes: {CantidadLikes}, vistas: {CantidadVisualizaciones}, fecha de subida: {Fecha.ToString("yyyy-MM-dd")}");
}
}


