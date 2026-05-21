using System;
using System.Collections.Generic;
using System.Text;

namespace L14_JAML_1101226
{
    internal class CuentaBancaria
    {
        string titular;
        string numeroCuenta;
        double saldo;
        public CuentaBancaria(string titular, string numeroCuenta, double saldo)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }
        public void mostrarInformacionBanco()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Número de Cuenta: " + numeroCuenta);
            Console.WriteLine("Saldo: Q" + saldo);
        }
        public void depositar()
        {
            Console.WriteLine("El saldo antes del déposito es de: " + saldo);
            Console.WriteLine("Ingrese el monto a depositar:");
            double deposito = double.Parse(Console.ReadLine());
            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine("Depósito exitoso. Nuevo saldo: Q" + saldo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Monto de depósito no válido.");
                Console.ResetColor();
            }
        }
        public void retirar()
        {
            Console.WriteLine("El saldo antes del retiro es de: " + saldo);
            Console.WriteLine("Ingrese el monto a retirar:");
            double retiro = double.Parse(Console.ReadLine());
            if (retiro > 0 && retiro <= saldo)
            {
                saldo -= retiro;
                Console.WriteLine("Retiro exitoso. Nuevo saldo: Q" + saldo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Monto de retiro no válido o saldo insuficiente.");
                Console.ResetColor();
            }
        }
    }
}