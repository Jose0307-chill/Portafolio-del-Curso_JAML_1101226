using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("================    Ejercicio #1    =================");
        Console.WriteLine("=====================================================");
        int n = 2;
        float a; //a será nuestra variable para almacenar los números que el usuario ingrese.
        float promedio;
        Console.WriteLine("Ingrese el número 1");
        a = int.Parse(Console.ReadLine());
        int b = (int)a; //b será nuestra variable para determinar el número mayor.
        int c = (int)a; //c será nuestra variable para determinar el número menor.
        float suma = a;
        while (n <= 20)
        {
            Console.WriteLine("Ingrese el número " + n);
            a = float.Parse(Console.ReadLine());
            if (a > b)
            {
                b = (int)a;
            }
            if (a < c)
            {
                c = (int)a;
            }
            suma = suma + a;
            n++;
        }
        promedio = suma / 20; //Calculamos el promedio total de los 20 números ingresados.
        Console.WriteLine("El número mayor es: " + b);
        Console.WriteLine("El número menor es: " + c);
        Console.WriteLine("El promedio es: " + promedio);
        Console.ReadLine();
        Console.WriteLine("=====================================================");
        Console.WriteLine("================    Ejercicio #2    =================");
        Console.WriteLine("=====================================================");
        int incremento;
        for (incremento = 0; incremento <= 100; incremento++)
        {
            if (incremento % 2 == 0 && incremento % 7 == 0)
            {
                Console.WriteLine(incremento + " ParSiete");
            }
            else if (incremento % 2 == 0)
            {
                Console.WriteLine(incremento + " Par");
            }
            else if (incremento % 7 == 0)
            {
                Console.WriteLine(incremento + " Siete");
            }
            else
            {
                Console.WriteLine(incremento);
            }
        }
        Console.ReadLine();
        Console.WriteLine("=====================================================");
        Console.WriteLine("================    Ejercicio #3    =================");
        Console.WriteLine("=====================================================");
        int contador = 1;
        int contadorDescuento = 0;
        float sumaCompra = 0;
        float montoCompra;
        while (contador <= 10)
        {
            Console.WriteLine("Ingrese el monto de compra del cliente " + contador);
            montoCompra = float.Parse(Console.ReadLine());
            if (montoCompra > 700)
            {
                montoCompra = montoCompra - (montoCompra * 0.12f);
                contadorDescuento++;
            }
            else if (montoCompra > 300 && montoCompra <= 700)
            {
                montoCompra = montoCompra - (montoCompra * 0.05f);
                contadorDescuento++;
            }
            Console.WriteLine("El cliente " + contador + " debe pagar: " + montoCompra);
            sumaCompra = sumaCompra + montoCompra;
            contador++;
        }
        Console.WriteLine("");
        Console.WriteLine(contadorDescuento + " clientes recibieron descuento");
        Console.WriteLine("El total de las compras del día es: " + sumaCompra);
        Console.ReadLine();
        Console.WriteLine("=====================================================");
        Console.WriteLine("================    Ejercicio #4    =================");
        Console.WriteLine("=====================================================");
        int opcion = 0;
        int numero;
        while (opcion != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el número de la operación que desea realizar:");
            Console.WriteLine("1. Mostrar los números desde el número ingresado hasta el 1");
            Console.WriteLine("2. Mostrar los múltiplos de 3 hasta el número ingresado");
            Console.WriteLine("3. Mostrar los múltiplos de 5 hasta el número ingresado");
            Console.WriteLine("4. Salir");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());
                for (int i = numero; i >= 1; i--)
                {
                    Console.Write(i + " ");
                }
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 4.");
            }
        }
        Console.ReadLine();
        Console.WriteLine("=====================================================");
        Console.WriteLine("================    Ejercicio #5    =================");
        Console.WriteLine("=====================================================");
        int asteriscos;
        Console.WriteLine("Ingrese el número de asteriscos que desea mostrar de la torre:");
        asteriscos = int.Parse(Console.ReadLine());
        for (int i = 1; i <= asteriscos; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}