namespace Biblioteca;
public class MotorElectico : Motor
{
    public override double CalcularConsumo(double km) => km * 20;
}