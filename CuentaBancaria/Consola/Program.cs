using Biblioteca;

Console.WriteLine("Ingrese numero de cuenta: ");
int NumeroCuenta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el numero del titular: ");
int NumeroTitular = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su tipo de moneda: ");
string Moneda = Console.ReadLine();
Console.WriteLine("Ingrese su saldo: ");
decimal SaldoActual = Convert.ToInt32(Console.ReadLine());
CuentaBancaria cuentabancaria =  new CuentaBancaria(NumeroCuenta,NumeroTitular,Moneda,SaldoActual);

cuentabancaria.Depositar(500);
cuentabancaria.Retirar(1000);
cuentabancaria.Informar();

