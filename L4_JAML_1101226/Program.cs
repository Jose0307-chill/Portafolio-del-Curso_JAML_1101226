using System;
class Program
{
    static void Main()
    {
        //Ejercicio #1: Declaración de variables
        string nombre_personaje = "Sonic";
        int nivel = 54;
        float salud = 101.76f;
        bool es_jefe = false;
        Console.WriteLine("El personaje " + nombre_personaje + " tiene un nivel de " + nivel + ", una salud de " + salud + " y es jefe: " + es_jefe);
        Console.ReadLine();

        //Ejercicio #2: Conversión implicita
        int numero_entero = 1500;
        long numero_largo;
        numero_largo = numero_entero;
        Console.WriteLine(numero_largo);
        double numero_decimal;
        numero_decimal = numero_largo;
        Console.WriteLine(numero_decimal);
        Console.ReadLine();

        //Ejercicio #3: Casting Explícito
        double precio_exacto = 45.89;
        int precio_redondeado;
        precio_redondeado = (int)precio_exacto;
        Console.WriteLine("El precio original es: " + precio_exacto + " .El precio redondeado es de: " + precio_redondeado);
        Console.ReadLine();
        //Los decimales únicamente desaparecen, dejando sola a la parte entera, pero no realizan un redondeo matemáticamente correcto.

        //Ejercicio #4: De texto a Número
        int numero;
        Console.WriteLine("Ingresar un número: ");
        string entrada_usuario = Console.ReadLine();
        numero = int.Parse(entrada_usuario) + 5;
        Console.WriteLine("El resultado de la suma es de: " + numero);
        Console.ReadLine();
        //El programa tira un error, debido a que no se puede cambiar ímplicitamente el tipo 'string'
        //al tipo 'int'. C# dice que no se puede convertir implicitamente el tipo 'string' en 'int'.

        //Ejercicio #5: Clase Convert
        string valor_texto = "true";
        bool valor_booleano = Convert.ToBoolean(valor_texto);
        string valor_decimal = "25.5";
        double valor_double = Convert.ToDouble(valor_decimal);
        Console.WriteLine("El valor booleano es: " + valor_booleano + " y el valor double es: " + valor_double);
        Console.ReadLine();

        //Ejercicio #6: Conversión a texto
        double pi = 3.14159;
        string cadena = pi.ToString("F2");
        Console.WriteLine(cadena);
        Console.ReadLine();

        //Ejercicio #7: Calculadora de IVA
        double IVA;
        double total;
        int total_real;
        Console.WriteLine("Ingrese el precio del producto: ");
        string precio = Console.ReadLine();
        double precio_producto = Convert.ToDouble(precio);
        IVA = precio_producto * 0.21;
        total = precio_producto + IVA;
        total_real = (int)total;
        Console.WriteLine("El total a pagar es: " + total_real);
        Console.ReadLine();
    }
}

