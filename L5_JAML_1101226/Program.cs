using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=============================================================");
        Console.WriteLine("Desafío #1: Identificación de Número");
        Console.WriteLine("=============================================================");
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine()); //Entrada
        if (num == 0)
        {
            Console.WriteLine("El número ingresado es neutro, osea: " + num); //Salida
        }
        else if (num > 0)
        {
            Console.WriteLine("El número ingresado es positivo"); //Salida
        }
        else
        {
            Console.WriteLine("El número ingresado es negativo"); //Salida
        }
        Console.WriteLine("=============================================================");
        Console.WriteLine("Desafío #2: Año bisiesto");
        Console.WriteLine("=============================================================");
        Console.WriteLine("Ingrese un año:");
        int annio = int.Parse(Console.ReadLine()); //Entrada
        if (annio <= 0)
        {
            Console.WriteLine("El año no puede ser 0 o un número negativo"); //Salida
        }
        else if (annio % 4 == 0 && annio % 100 != 0 || annio % 400 == 0)
        {
            Console.WriteLine("El año ingresado es bisiesto"); //Salida
        }
        else
        {
            Console.WriteLine("El año ingresado no es bisiesto"); //Salida
        }
        Console.WriteLine("=============================================================");
        Console.WriteLine("Desafío #3: Boleto de ornato");
        Console.WriteLine("=============================================================");
        Console.WriteLine("Ingrese su salario mensual:");
        float salario = float.Parse(Console.ReadLine()); //Entrada
        Console.WriteLine("¿Usted tiene multa? Escriba el número correspondiente (Si = 1, No = 0)");
        bool multa = Console.ReadLine() == "1"; //Entrada
        if (salario <= 500)
        {
            Console.WriteLine("Usted no debe pagar ornato"); //Salida
        }
        else if (salario > 500 && salario <= 1000)
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q10.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q20.00"); //Salida
            }
        }
        else if (salario > 1000 && salario <= 3000)
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q15.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q30.00"); //Salida
            }
        }
        else if (salario > 3000 && salario <= 6000)
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q50.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q100.00"); //Salida
            }
        }
        else if (salario > 6000 && salario <= 9000)
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q75.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q150.00"); //Salida
            }
        }
        else if (salario > 9000 && salario <= 12000)
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q100.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q200.00"); //Salida
            }
        }
        else
        {
            if (!multa)
                Console.WriteLine("Usted debe pagar: Q150.00"); //Salida
            else
            {
                Console.WriteLine("Usted debe pagar: Q300.00"); //Salida
            }
        }
        Console.WriteLine("=============================================================");
        Console.WriteLine("Desafío #4: Sistema de parqueo");
        Console.WriteLine("=============================================================");
        int tarifa = 10;
        Console.WriteLine("Ingrese el número de horas que estuvo parqueado:");
        int horas = int.Parse(Console.ReadLine()); //Entrada
        int monto = horas * tarifa;
        Console.WriteLine("Usted debe pagar: Q" + monto); //Salida
        Console.WriteLine("Ingrese la cantidad de dinero con la que pagará:");
        int pago = int.Parse(Console.ReadLine()); //Entrada
        if (pago < monto)
        {
            Console.WriteLine("Error. Pago insuficiente"); //Salida
        }
        else if (pago == monto)
        {
            Console.WriteLine("Pago exacto, no se requiere cambio. ¡Que tenga un buen día!"); //Salida
        }
        else
        {
            Console.WriteLine("Pago excedente. Su cambio es: Q" + (pago - monto)); //Salida
            int billetes100 = (pago - monto) / 100;
            int billetes50 = ((pago - monto) % 100) / 50;
            int billetes20 = (((pago - monto) % 100) % 50) / 20;
            int billetes10 = ((((pago - monto) % 100) % 50) % 20) / 10;
            int billetes5 = (((((pago - monto) % 100) % 50) % 20) % 10) / 5;
            int billetes1 = (((((pago - monto) % 100) % 50) % 20) % 10) % 5;
            Console.WriteLine("Su cambio se compone de: ");
            Console.WriteLine(billetes100 + " billetes de Q100");
            Console.WriteLine(billetes50 + " billetes de Q50");
            Console.WriteLine(billetes20 + " billetes de Q20");
            Console.WriteLine(billetes10 + " billetes de Q10");
            Console.WriteLine(billetes5 + " billetes de Q5");
            Console.WriteLine(billetes1 + " billetes de Q1");
        } 
    }
}
