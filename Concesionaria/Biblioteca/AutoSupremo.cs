namespace Biblioteca;

public class AutoSupremo
{
public string NumeroSerieMotor {get; set;}
public string Marca {get; set;}
public int Anio {get; set;}
public decimal Precio {get; set;}
public string Variante {get; set;}

public AutoSupremo(string numeroSerieMotor, string marca, int anio, decimal precio, string variante)
{
    NumeroSerieMotor = numeroSerieMotor;
    Marca = marca;
    Anio = anio;
    Precio = precio;
    Variante = variante;
} 



}
