namespace Biblioteca;

public class CuentaBancaria
{
public int NumeroCuenta { get; set; }
public int NumeroTitular { get; set; }
public string Moneda { get; set; }
public decimal SaldoActual  { get; set; } 
public CuentaBancaria(int NumeroCuenta, int NumeroTitular, string Moneda, decimal SaldoActual)
{
    this.NumeroCuenta = NumeroCuenta;
    this.NumeroTitular = NumeroTitular;
    this.Moneda = Moneda;
if(SaldoActual < 0)
{
    throw new ArgumentException("Saldo cuenta incorrecto");
}
else
{
    this.SaldoActual = SaldoActual;
}
}
public void Depositar(int CantidadDepositar)
{
    SaldoActual = SaldoActual + CantidadDepositar;
}
public void Retirar(int CantidadRetirar)
{
    if ( CantidadRetirar > SaldoActual)
    {
        throw new ArgumentException("Saldo Insuficiente");
    }
    SaldoActual = SaldoActual - CantidadRetirar;
}   
public void Informar()
{
    Console.WriteLine($"El numero de cuenta es {NumeroCuenta}");
    Console.WriteLine($"El numero titular de la cuenta es {NumeroTitular}");
    Console.WriteLine($"El tipo de moneda de la cuenta es {Moneda}");
    Console.WriteLine($"El saldo actual de la cuenta es {SaldoActual}");
}


}
