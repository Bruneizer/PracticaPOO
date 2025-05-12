namespace Biblioteca;

public class Motocicleta
{
public  string? Patente { get; set; }
public  string? Color { get; set; }
public  string? Modelo { get; set; }
public bool EstadoMotor { get; set; } = false;
public Motocicleta(string Patente, string Color, string Modelo)
{
    this.Patente = Patente;
    this.Color = Color;
    this.Modelo = Modelo;
    
}
public void Encender()
{
 EstadoMotor = true;
}public void Apagar()
{
 EstadoMotor = false;
}
public void Verificar()
{
    if(EstadoMotor == true){
        Console.WriteLine("Esta encendido");
    }
    else
    {
        Console.WriteLine("Esta apagado");
    }
}
public void informar()
{
    Console.WriteLine($"La motocicleta de modelo {Modelo} con patente {Patente} y color {Color} ");
}

}
