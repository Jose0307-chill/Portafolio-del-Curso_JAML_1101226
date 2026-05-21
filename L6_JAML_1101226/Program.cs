using System;
class program
{
    static void Main()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("Problema #1");
        Console.WriteLine("==================================");
        bool resultado = (4 * 5 > 20) && (4 >= 8);
        Console.WriteLine("El resultado de la expresión es: " + resultado);
        bool resultado2 = (14 % 3 == 4) || (true);
        Console.WriteLine("El resultado de la expresión es: " + resultado2);
        bool resultado3 = 6 - 5 * 4 + 10 == 4;
        Console.WriteLine("El resultado de la expresión es: " + resultado3);
        bool resultado4 = (24 / 8 + 4 * 6) <= 30;
        Console.WriteLine("El resultado de la expresión es: " + resultado4);
        Console.WriteLine("==================================");
        Console.WriteLine("Problema #2"); //El diagrama de flujo se encuentra en el archivo ZIP
        Console.WriteLine("==================================");
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0 && num % 7 == 0 && num % 28 != 0)
        {
            Console.WriteLine("El número es especial.");
        }
        else
        {
            Console.WriteLine("El número no es especial.");
        }
        Console.WriteLine("==================================");
        Console.WriteLine("Problema #3");
        Console.WriteLine("==================================");
        Console.WriteLine("Ingrese el número de la conversión que quiere realizar");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.WriteLine("3. Celsius a Kelvin");
        Console.WriteLine("4. Cerrar programa");
        int opcion = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de la temperatura que desea convertir");
        float temperatura = float.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                double respuesta = (temperatura * 9 / 5) + 32;
                Console.WriteLine("La temperatura en Fahrenheit es: " + respuesta);
                break;
            case 2:
                double respuesta2 = (temperatura - 32) * 5 / 9;
                Console.WriteLine("La temperatura en Celsius es: " + respuesta2);
                break;
            case 3:
                double respuesta3 = temperatura + 273.15;
                Console.WriteLine("La temperatura en Kelvin es: " + respuesta3);
                break;
            case 4:
                Console.WriteLine("Programa cerrado.");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        Console.WriteLine("==================================");
        Console.WriteLine("Problema #4");
        Console.WriteLine("==================================");
        Console.WriteLine("Ingrese el tipo de sangre del paciente (incluya el signo (+/-)):");
        string tipoSangre = Console.ReadLine().ToUpper();
        switch (tipoSangre)
        {
            case "A+":
                Console.WriteLine("El paciente puede recibir sangre de O-, O+, A- y A+.");
                break;
            case "A-":
                Console.WriteLine("El paciente puede recibir sangre de O- y A-.");
                break;
            case "B+":
                Console.WriteLine("El paciente puede recibir sangre de O-, O+, B+ y B-.");
                break;
            case "B-":
                Console.WriteLine("El paciente puede recibir sangre de O- y B-.");
                break;
            case "AB+":
                Console.WriteLine("El paciente puede recibir sangre de cualquier tipo.");
                break;
            case "AB-":
                Console.WriteLine("El paciente puede recibir sangre de O-, B-, A- y AB-");
                break;
            case "O+":
                Console.WriteLine("El paciente puede recibir sangre de O+ y O-.");
                break;
            case "O-":
                Console.WriteLine("El paciente puede recibir sangre de O-.");
                break;
            default:
                Console.WriteLine("Tipo de sangre no válido.");
                break;
        }
    }
}