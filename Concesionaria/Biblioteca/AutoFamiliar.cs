namespace Biblioteca;
public class AutoFamiliar : AutoSupremo
{
    public int CantidadDePasajetos { get; set; }
        public AutoFamiliar(string numeroSerieMotor, string marca,int anio, decimal precio,double kilometraje,int cantidadDePasajeros) 
    : base(numeroSerieMotor, marca, anio, precio,kilometraje,motor)
    {
        CantidadDePasajetos = cantidadDePasajeros;
    }
    
}