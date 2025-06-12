namespace Biblioteca;

public class AutoSupremo
{
public string NumeroSerieMotor {get; set;}
public string Marca {get; set;}
public int Anio {get; set;}
public decimal Precio {get; set;}
public double Kilometraje {get; set;}
public Motor motor {get; set;}

public AutoSupremo(string numeroSerieMotor, string marca, int anio, decimal precio, double kilometraje,Motor motor)
{
    NumeroSerieMotor = numeroSerieMotor;
    Marca = marca;
    Anio = anio;
    Precio = precio;
    Kilometraje = kilometraje;
    Motor = motor;
} 



}
