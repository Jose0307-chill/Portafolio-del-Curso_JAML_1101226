using System;
class program
{
    static void Main()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("===============  Ejercicio #1  ===============");
        Console.WriteLine("==============================================");
        int num;
        bool validacion = false;
        Console.WriteLine("Ingrese un número entero positivo:");
        do
        {
            num = int.Parse(Console.ReadLine());
            if (num <= -1)
            {
                Console.WriteLine("El número ingresado no puede ser negativo, por favor ingrese un número entero positivo.");
                validacion = false;
            }
            else
            {
                Console.WriteLine("La suma de los dígitos del número ingresado es: " + suma(num));
                validacion = true;
            }
        } while (!validacion);
        Console.WriteLine("==============================================");
        Console.WriteLine("===============  Ejercicio #2  ===============");
        Console.WriteLine("==============================================");
        Console.WriteLine("Ingrese sus datos (sin tildes):");
        string primerNombre = nombre("Primer nombre: ").ToLower();
        string segundoNombre = nombre("Segundo nombre: ").ToLower();
        string primerApellido = nombre("Primer apellido: ").ToLower();
        string segundoApellido = nombre("Segundo apellido: ").ToLower();
        Console.WriteLine("El correo institucional generado con los datos inresados es:" + correo(primerNombre, segundoNombre, primerApellido, segundoApellido));
        Console.WriteLine("==============================================");
        Console.WriteLine("===============  Ejercicio #3  ===============");
        Console.WriteLine("==============================================");
        Console.WriteLine("Escriba la temperatura en °C para obtenerla en °F");
        double tempF = 0;
        string tempC = Console.ReadLine();
        Console.WriteLine("La temperatuar en °F es: " + conversion(tempC, ref tempF));
        Console.WriteLine("==============================================");
        Console.WriteLine("===============  Ejercicio #4  ===============");
        Console.WriteLine("==============================================");
        int puntos = 0;
        Console.WriteLine("¿Qué desea realizar?, seleccione una opción:");
        Console.WriteLine("1. Aumentar puntos");
        Console.WriteLine("2. Quitar puntos");
        Console.WriteLine("3. Obtener nivel");
        Console.WriteLine("4. Evaluar estado");
        Console.WriteLine("5. Salir");
        int opcion = 0;
        while (opcion != 5)
        {
            Console.WriteLine("Seleccione otra opción:");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                agregar(ref puntos);
                Console.WriteLine("Puntos actuales: " + puntos);
            }
            else if (opcion == 2)
            {
                quitar(ref puntos);
                Console.WriteLine("Puntos actuales: " + puntos);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("El nivel actual es: " + nivel(puntos));
            }
            else if (opcion == 4)
            {
                Console.WriteLine("El estado actual es: " + estado(puntos));
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida, por favor seleccione una opción del 1 al 5.");
            }
        }
    }
    static int suma(int a)
    {
        int suma = 0;
        while (a > 0)
        {
            suma = suma + (a % 10);
            a = a / 10;
        }
        return suma;
    }
    static string nombre(string mensaje)
    {
        Console.WriteLine(mensaje);
        string nom = Console.ReadLine();
        return nom;
    }
    static string correo(string PN, string SN, string PA, string SA)
    {
        string correo = PN[0].ToString() + SN[0].ToString() + PA + SA[0].ToString() + "@correo.url.edu.gt";
        return correo;
    }
    static string conversion(string tempC, ref double tempF)
    {
        if (tempC.EndsWith("C") || tempC.EndsWith("c"))
        {
            tempC = tempC.Substring(0, tempC.Length - 1);
        }
        double ValortempC = double.Parse(tempC);
        tempF = (ValortempC * 9 / 5) + 32;
        return tempF.ToString();
    }
    static int agregar(ref int puntos)
    {
        if (puntos + 10 > 100)
        {
            int resto = 100 - puntos;
            puntos = puntos + resto;
            Console.WriteLine("La cantidad de puntos no puede ser mayor a 100");
            return puntos;
        }
        else
        {
            puntos = puntos + 10;
            return puntos;
        }
    }
    static int quitar(ref int puntos)
    {
        if (puntos - 7 < 0)
        {
            puntos = puntos - puntos;
            Console.WriteLine("La cantidad de puntos no puede ser menor a 0");
            return puntos;
        }
        else
        {
            puntos = puntos - 7;
            return puntos;
        }
    }
    static string nivel(int puntos)
    {
        if (puntos >= 0 && puntos <= 49)
        {
            return "Básico";
        }
        else if (puntos >= 50 && puntos <= 79)
        {
            return "Intermedio";
        }
        else if (puntos >= 80 && puntos <= 100)
        {
            return "Avanzado";
        }
        else
        {
            return "Puntos fuera de rango";
        }
    }
    static string estado(int puntos)
    {
        if (puntos >= 1 && puntos <= 69)
        {
            return "Reprobado";
        }
        else if (puntos >= 70 && puntos <= 99)
        {
            return "Aprobado";
        }
        else if (puntos == 100)
        {
            return "Excelente";
        }
        else
        {
            return "Puntos fuera de rango";
        }
    }
}