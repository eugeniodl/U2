﻿CuentaBancaria cuenta = new CuentaBancaria("1234567890", 5000m);
cuenta.Depositar(1500m);
cuenta.Retirar(3000m);
Console.WriteLine($"Saldo final: {cuenta.ConsultarSaldo():C}");