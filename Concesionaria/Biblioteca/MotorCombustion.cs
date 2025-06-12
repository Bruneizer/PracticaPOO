namespace Biblioteca;
public class MotorCombustion : Motor
{
    public string TipoVehiculo {get; set;}
    public MotorCombustion(string tipoVehiculo)
    {
        TipoVehiculo = tipoVehiculo;
    }
   public override double CalcularConsumo(double km)
    {
        return TipoVehiculo == "Camioneta" ? km / 10 : km / 13;
    }
}