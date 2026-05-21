using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("==================== Ejercicio #1 ================");
        Console.WriteLine("==================================================");
        Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();
        bool palindroma = true;
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                palindroma = false;
                break;
            }
        }
        if (palindroma)
        {
            Console.WriteLine("Es una palabra palíndroma.");
        }
        else
        {
            Console.WriteLine("No es una palabra palíndroma.");
        }
        Console.WriteLine("Presione ENTER para continuar");
        Console.ReadLine();
        Console.Clear();
        //El ejercicio #2, comienza desde aquí.
        bool validacion = false;
        string[] español = new string[5] { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] inglés = new string[5] { "red", "blue", "yellow", "white", "green" };
        string[] italiano = new string[5] { "rosso", "blu", "giallo", "bianco", "verde" };
        do
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("==================== Ejercicio #2 ================");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese el número de la opción que desea realizar");
            Console.WriteLine("1. Practicar lección");
            Console.WriteLine("2. Terminar lección");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingrese un color en español: ");
                string resColor = Console.ReadLine().ToLower();
                for (int i = 0; i < español.Length; i++)
                {
                    if (español[i] == resColor)
                    {
                        Console.WriteLine("La traducción a inglés del color ingresado es: " + inglés[i]);
                        Console.WriteLine("La traducción a italiano del color ingresado es: " + italiano[i]);
                        validacion = true;
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else if (i == español.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: El color ingresado no se puede traducir");
                        Console.ResetColor();
                        validacion = true;
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Lección terminada. ¡Hasta luego!");
                validacion = false;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Opción no válida.");
                Console.ResetColor();
                validacion = true;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        } while (validacion);
        //El ejercicio #3, comienza desde aquí.
        validacion = false;
        Random numero = new Random();
        int[] calificaciones = new int [10];
        for (int i = 0; i < 10; i++)
        {
            calificaciones[i] = numero.Next(50, 101);
        }
        do
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("==================== Ejercicio #3 ================");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingrese la opción que desea realizar");
            Console.WriteLine("1. Reporte de rendimiento");
            Console.WriteLine("2. Estadísticas");
            Console.WriteLine("3. Salir");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (calificaciones[i] >= 50 && calificaciones[i] <= 64)
                    {
                        Console.Write("Calificación " + (i + 1) + ": ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(calificaciones[i] +" ");
                        Console.ResetColor();
                    }
                    else if (calificaciones[i] >= 65 && calificaciones[i] <= 79)
                    {
                        Console.Write("Calificación " + (i + 1) + ": ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(calificaciones[i] + " ");
                        Console.ResetColor();
                    }
                    else if (calificaciones[i] >= 80 && calificaciones[i] <= 100)
                    {
                        Console.Write("Calificación " + (i + 1) + ": ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(calificaciones[i] + " ");
                        Console.ResetColor(); 
                    }                  
                }
                validacion = true;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else if (opcion == 2)
            {
                double promedio = 0;
                int menor = 100;
                int mayor = 0;
                for (int i = 0; i < 10; i++)
                {
                    promedio = promedio + calificaciones[i];
                    if (mayor < calificaciones[i])
                    {
                        mayor = calificaciones[i];
                    }
                    if (menor > calificaciones[i])
                    {
                        menor = calificaciones[i];
                    }
                }
                promedio = promedio / 10;
                Console.WriteLine("Promedio de calificaciones: " + promedio);
                Console.WriteLine("Calificación más baja: " + menor);
                Console.WriteLine("Calificación más alta: " + mayor);
                validacion = true;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Saliendo del programa...");
                validacion = false;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Opción no válida.");
                Console.ResetColor();
                validacion = true;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        } while (validacion);
        //El ejercicio #4, comienza desde aquí.
        double salarioTotal;
        string[] trabajadores = new string[6] { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
        double[] salariosPorHora = new double[6] { 100, 125.50, 98.65, 125, 132.50, 102.50 };
        int[] horas = new int[6];
        Console.WriteLine("==================================================");
        Console.WriteLine("==================== Ejercicio #4 ================");
        Console.WriteLine("==================================================");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Ingrese las horas trabajadas por " + trabajadores[i] + ": ");
            horas[i] = int.Parse(Console.ReadLine());
            if (horas[i] < 0 || horas[i] > 168) //168 es el máximo de horas que tiene una semana, por lo que se valida que no se trabaje más allá de ese límite. 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El número de horas trabajadas no es válido. Ingrese un número entre 0 y 168.");
                Console.ResetColor();
                i--; //Se resta 1 al índice para que el programa vuelva a solicitar las horas trabajadas para el mismo trabajador, ya que el valor ingresado no es válido.
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (horas[i] > 40)
            {
                salarioTotal = (horas[i] - 40) * (salariosPorHora[i] * 1.5) + (salariosPorHora[i] * 40);
            }
            else
            {
                salarioTotal = horas[i] * salariosPorHora[i];
            }
            Console.WriteLine("El salario total de " + trabajadores[i] + " es: " + salarioTotal);
        }
        Console.WriteLine("Presione ENTER para salir");
        Console.ReadLine();
        Console.Clear();
    }
}