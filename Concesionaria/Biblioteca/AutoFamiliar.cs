namespace Biblioteca;
public class AutoFamiliar : AutoSupremo
{
    public int CantidadDePasajetos { get; set; }
        public AutosDeportivo(string numeroSerieMotor, string marca,int anio, decimal precio,string variante,cantidadDePasajeros) 
    : base(numeroSerieMotor, marca, anio, precio,variante)
    {
        CantidadDePasajetos = cantidadDePasajetos;
    }
    
}