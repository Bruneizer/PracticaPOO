namespace Biblioteca;
public class Camioneta : AutoSupremo
{
    public decimal CapacidadDeCarga { get; set; }

    public Camioneta(string numeroSerieMotor, string marca,int anio, decimal precio,string variante,capacidadDeCarga ) 
    : base(numeroSerieMotor, marca, anio, precio,variante)
    {
        CapacidadDeCarga = CapacidadDeCarga;

    }
    
}