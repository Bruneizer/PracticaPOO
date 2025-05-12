namespace Biblioteca;

public class Cafetera
{
public int CantidadMaxima {get; set;}
public int CantidadActual {get; set;}
public int Taza {get; set;}


public Cafetera (int cantidadActual)
{
    CantidadMaxima = 1500;
    Taza = 0;   
    if(cantidadActual < 0)
    {
        throw new ArgumentException ("La cantidad no puede ser negativa");
    }
    if(cantidadActual > CantidadMaxima)
    {
        cantidadActual = CantidadMaxima;
    }
        CantidadActual = cantidadActual;
    
    
}
public void HacerCafe()
{
    CantidadActual = CantidadMaxima;
}
public void ServirCafe(int servirCafe)
{
CantidadActual = CantidadActual - servirCafe;
Taza = Taza + servirCafe;
}
public void VaciarCafetera()
{
    CantidadActual = 0;
}
public void Informar()
{
Console.WriteLine($"La cafetera tiene {CantidadActual} y la taza de cafe tiene {Taza}");
}

}
