using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("Problema #1: Estructura While");
        Console.WriteLine("=================================================");
        string nombre = "José Adrián Méndez López";
        int carnet = 1101226;
        int indice = 1;
        Console.WriteLine("Nombre: " + nombre + " y No. de Carnet: " + carnet);
        while (indice <= 20)
        {
            if (indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(indice);
            indice++;
        }
        Console.ResetColor();
        Console.WriteLine("=================================================");
        Console.WriteLine("Problema #2: Estructura Do-While");
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese un número entero positivo:");
        int num = int.Parse(Console.ReadLine());
        int contador = num;
        if (num <= 0)
        {
            Console.WriteLine("Número inválido. Ingrese un número entero positivo.");
        }
        Console.WriteLine("Los divisores de " + num + " son:");
        do
        {
            if (num % contador == 0)
            {
                Console.Write(contador + " ");
            }
            contador--;
        } while (contador > 0);
        Console.WriteLine();
        Console.WriteLine("=================================================");
        Console.WriteLine("Problema #3: Estructura For");
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese un número para averiguar la serie Fibonacci:");
        int n = int.Parse(Console.ReadLine());
        int num1 = 1;
        int num2 = 1;
        int num3 = 1;
        Console.WriteLine("La serie Fibonacci hasta el término " + n + " es:");
        Console.Write("0 1");
        for (int i = 3; i <= n; i++)
        {
            num1 = num3;
            num2 = num1 + num2;
            Console.Write(" " + num2);
            num3 = num2;
            num2 = num1;
        }
        Console.WriteLine();
        Console.ReadLine();
        Console.WriteLine("=================================================");
        Console.WriteLine("Problema #4: Estructura Ciclos anidados");
        Console.WriteLine("=================================================");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("Tabla de multiplicar del " + i + ":");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }
            Console.WriteLine();
        }
    }
}