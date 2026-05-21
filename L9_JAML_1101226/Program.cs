using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("================  Ejercicio #1  ===========");
        Console.WriteLine("===========================================");
        Console.WriteLine("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        caracteres(palabra);
        Console.WriteLine("===========================================");
        Console.WriteLine("================  Ejercicio #2  ===========");
        Console.WriteLine("===========================================");
        Console.WriteLine("Ingrese un número (A): ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número (B): ");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("Los números ingresados incialmente fueron: " + A + " y " + B);
        intercambio(ref A, ref B);
        Console.WriteLine("Los números después del intercambio son: " + A + " y " + B);
        Console.WriteLine("===========================================");
        Console.WriteLine("================  Ejercicio #3  ===========");
        Console.WriteLine("===========================================");
        double precio = 48.50;
        double descuento1 = 0.5;
        double descuento2 = 0.15;
        double descuento3 = 0.9;
        Console.WriteLine("¿Es usted niño(1), adulto mayor(2), posee membresía(3) o ninguna(4)? Seleccione una respuesta (1, 2, 3, 4): ");
        int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El precio inicial es(Q): " + precio);
                    Console.WriteLine("El descuento aplicado será de(Q): " + (precio * descuento1));
                    porcentaje(ref precio, descuento1);
                    Console.WriteLine("El precio con descuento para niños es(Q): " + precio);
                    break;
                case 2:
                    Console.WriteLine("El precio inicial es(Q): " + precio);
                    Console.WriteLine("El descuento aplicado será de(Q): " + (precio * descuento2));
                    porcentaje(ref precio, descuento2);
                    Console.WriteLine("El precio con descuento para adultos mayores es(Q): " + precio);
                    break;
                case 3:
                    Console.WriteLine("El precio inicial es(Q): " + precio);
                    Console.WriteLine("El descuento aplicado será de(Q): " + (precio * descuento3));
                    porcentaje(ref precio, descuento3);
                    Console.WriteLine("El precio con descuento para miembros es(Q): " + precio);
                    break;
                case 4:
                    Console.WriteLine("El precio inicial es(Q): " + precio);
                    Console.WriteLine("No se aplicará ningún descuento, el precio final es(Q): " + precio);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        
        
        Console.WriteLine("===========================================");
        Console.WriteLine("==============  Ejercicio #4  =============");
        Console.WriteLine("===========================================");
        Console.WriteLine("Usted es un jugador que posee 15 puntos de salud, " +
        "para completar el nivel debe derrotar a 10 enemigos en total, " +
        "con cada golpe, usted recibirá 5 puntos de daño. Cuenta con un total de 7 curaciones que le brindarán 3 puntos de salud extra. ¡Buena Suerte!");
        int puntosSalud = 15;
        int numeroCuraciones = 7;
        int enemigos = 10;
        int enemigosDerrotados = 0;
        while (puntosSalud > 0 && enemigosDerrotados < 10)
        {
            Console.WriteLine("¿Qué acción desea realizar? (1. Atacar, 2. Curar, 3. Estado actual)");
            int decision = int.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    recibirDaño(ref puntosSalud);
                    enemigosDerrotados++;
                    enemigos--;
                    break;
                case 2:
                    if (puntosSalud >= 13)
                    {
                        numeroCuraciones = numeroCuraciones;
                    }
                    else
                    {
                        numeroCuraciones--;
                    }
                    curar(ref puntosSalud, numeroCuraciones);
                    break;
                case 3:
                    Console.WriteLine("Tu estado actual es el siguiente: ");
                    mostrarSalud(puntosSalud);
                    Console.WriteLine("Curaciones restantes: " + numeroCuraciones);
                    Console.WriteLine("Enemigos restantes: " + enemigos);
                    Console.WriteLine("Enemigos derrotados: " + enemigosDerrotados);
                    break;
                default:
                    Console.WriteLine("Acción no válida. Por favor, elige una acción válida.");
                    break;
            }
        }
        if (puntosSalud > 0)
        {
            Console.WriteLine("¡Felicidades, has derrotado a todos los enemigos y completado el nivel!");
            calificarDesempeño(puntosSalud);
        }
        else
        {
            Console.WriteLine("¡Has sido derrotado! Mejor suerte la próxima vez.");
        }
    }
    static void caracteres(string pal)  
    {
        int cantidad = pal.Length;
        Console.WriteLine("La cantidad de caracteres es: " + cantidad);
    }
    static void intercambio(ref int a, ref int b)
    {
        int x = a;
        a = b;
        b = x;
    }
    static void porcentaje(ref double descuento, double porcentaje)
    {
        double total = descuento - (descuento * porcentaje);
        descuento = total;
    }
    static void recibirDaño(ref int daño)
    {
        Random decision = new Random();
        bool decisionRandom = decision.Next(0, 2) == 0; 
        if (decisionRandom == true)
        {
            daño = daño - 5;
            Console.WriteLine("¡Has atacado al enemigo! Recibes 5 puntos de daño");
        }
        else
        {
            Console.WriteLine("¡Has derrotado al enemigo sin recibir daño!");
        }
    }
    static void curar(ref int salud, int vendas)
    {
        if (vendas == -1)
        {
            Console.WriteLine("¡No te quedan curaciones disponibles!");
        }
        else if (salud <= 12)
        {
            salud = salud + 3;
            Console.WriteLine("¡Te has curado!");
        }
        else
        {
            Console.WriteLine("Tu salud ya está al máximo o posees suficientes puntos de vida, no puedes curarte más.");
        }
    }
    static void mostrarSalud(int saludAColor)
    {
        if (saludAColor >= 11 && saludAColor <= 15)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (saludAColor >= 6 && saludAColor <= 10)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (saludAColor >= 1 && saludAColor <= 5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Tu salud actual es: " + saludAColor);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void calificarDesempeño(int saludFinal)
    {
        if (saludFinal == 15)
        {
            Console.WriteLine("Calificación:  S, tu salud fue de: "+ saludFinal);
        }
        else if (saludFinal >= 11 && saludFinal <= 14)
        {
            Console.WriteLine("Calificación: A, tu salud fue de: " + saludFinal);
        }
        else if (saludFinal >= 6 && saludFinal <= 10)
        {
            Console.WriteLine("Calificación: B, tu salud fue de: "+ saludFinal);
        }
        else
        {
            Console.WriteLine("Calificación: C, tu salud fue de: "+ saludFinal);
        }
    }
}