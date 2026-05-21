using L14_JAML_1101226;
using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        int opcion;
        bool validacion = false;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("======= LABORATORIO #14 =======");
            Console.ResetColor();
            Console.WriteLine("José Adrián Méndez López - 1101226");
            Console.WriteLine("1. Ejecutar ejercicio 1");
            Console.WriteLine("2. Ejecutar ejercicio 2");
            Console.WriteLine("3. Ejecutar ejercicio 3");
            Console.WriteLine("4. Salir");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out opcion))
            {
                if (opcion == 1)
                {
                    double saldo = 0;
                    Console.Clear();
                    Console.WriteLine("Creando cuenta 1...");
                    Console.WriteLine("Ingrese el titular de la cuenta:");
                    string titular1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de Cuenta:");
                    string numeroCuenta1 = Console.ReadLine();
                    CuentaBancaria cuenta1 = new CuentaBancaria(titular1, numeroCuenta1, saldo);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cuenta 1, creada con éxito");
                    Console.ResetColor();
                    Console.WriteLine("Creando cuenta 2...");
                    Console.WriteLine("Ingrese el titular de la cuenta:");
                    string titular2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de Cuenta:");
                    string numeroCuenta2 = Console.ReadLine();
                    CuentaBancaria cuenta2 = new CuentaBancaria(titular2, numeroCuenta2, saldo);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cuenta 2, creada con éxito");
                    Console.ResetColor();
                    do
                    {
                        Console.WriteLine("Mostrando información de la cuenta 1...");
                        cuenta1.mostrarInformacionBanco();
                        Console.WriteLine("Mostrando información de la cuenta 2...");
                        cuenta2.mostrarInformacionBanco();
                        Console.WriteLine("Ingrese la opción que desea realizar");
                        Console.WriteLine("1. Cuenta 1: Depositar");
                        Console.WriteLine("2. Cuenta 1: Retirar");
                        Console.WriteLine("3. Cuenta 2: Depositar");
                        Console.WriteLine("4. Cuenta 2: Retirar");
                        Console.WriteLine("5. Salir");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            cuenta1.depositar();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 2)
                        {
                            cuenta1.retirar();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 3)
                        {
                            cuenta2.depositar();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 4)
                        {

                            cuenta2.retirar();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 5)
                        {
                            Console.WriteLine("Saliendo del ejercicio #1...");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Opción no válida. Ingrese un número válido");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                    } while (validacion);
                    validacion = true;
                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Creando producto 1...");
                    Console.WriteLine("Ingrese el nombre del producto");
                    string nombre1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto (Q)");
                    double precio1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad inicial del producto");
                    int cantidad1 = int.Parse(Console.ReadLine());
                    Producto producto1 = new Producto(nombre1, precio1, cantidad1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Producto 1, creado con éxito");
                    Console.ResetColor();
                    Console.WriteLine("Creando producto 2...");
                    Console.WriteLine("Ingrese el nombre del producto");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto (Q)");
                    double precio2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad inicial del producto");
                    int cantidad2 = int.Parse(Console.ReadLine());
                    Producto producto2 = new Producto(nombre2, precio2, cantidad2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Producto 2, creado con éxito");
                    Console.ResetColor();
                    double dinero = 0;
                    do
                    {
                        Console.WriteLine("Mostrando información del producto 1...");
                        producto1.mostrarInformacionProducto();
                        Console.WriteLine("Mostrando información del producto 2...");
                        producto2.mostrarInformacionProducto();
                        Console.WriteLine("Dinero recaudado: Q" + dinero);
                        Console.WriteLine("Ingrese la opción que desea realizar");
                        Console.WriteLine("1. Vender: Producto 1");
                        Console.WriteLine("2. Reabastecer: Producto 1");
                        Console.WriteLine("3. Vender: Producto 2");
                        Console.WriteLine("4. Reabastecer: ¨Producto 2");
                        Console.WriteLine("5. Salir");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            producto1.vender(ref dinero);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 2)
                        {
                            producto1.reabastecer();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 3)
                        {
                            producto2.vender(ref dinero);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 4)
                        {
                            producto2.reabastecer();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 5)
                        {
                            Console.WriteLine("Saliendo del ejercicio #2...");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Opción no válida. Ingrese un número válido");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                    } while (validacion);
                    validacion = true;
                }
                else if (opcion == 3)
                {
                    Console.Clear();
                    double[] notas1 = new double[3];
                    Console.WriteLine("Ingresando los datos del estudiante 1...");
                    Console.WriteLine("Ingrese el nombre del estudiante:");
                    string nombre1 = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del estudiante:");
                    int edad1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el grado del estudiante:");
                    string grado1 = Console.ReadLine();
                    for (int i = 0; i < notas1.Length; i++)
                    {
                        Console.WriteLine("Ingrese la nota " + (i + 1) + " del estudiante:");
                        notas1[i] = double.Parse(Console.ReadLine());
                    }
                    Estudiante estudiante1 = new Estudiante(nombre1, edad1, grado1, notas1);
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("Datos del estudiante 1 ingresados con éxito");
                    Console.ResetColor();
                    double[] notas2 = new double[3];
                    Console.WriteLine("Ingresando los datos del estudiante 2...");
                    Console.WriteLine("Ingrese el nombre del estudiante:");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del estudiante:");
                    int edad2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el grado del estudiante:");
                    string grado2 = Console.ReadLine();
                    for (int i = 0; i < notas2.Length; i++)
                    {
                        Console.WriteLine("Ingrese la nota " + (i + 1) + " del estudiante:");
                        notas2[i] = double.Parse(Console.ReadLine());
                    }
                    Estudiante estudiante2 = new Estudiante(nombre2, edad2, grado2, notas2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Datos del estudiante 2 ingresados con éxito");
                    Console.ResetColor();
                    double promedio1 = 0;
                    double promedio2 = 0;
                    Console.WriteLine("Calculando promedios respectivamente...");
                    estudiante1.promedio(notas1, ref promedio1);
                    estudiante2.promedio(notas2, ref promedio2);
                    do
                    {
                        Console.WriteLine("Mostrando información del estudiante 1...");
                        estudiante1.mostrarInformacionEstudiante(promedio1);
                        Console.WriteLine("Mostrando información del estudiante 2...");
                        estudiante2.mostrarInformacionEstudiante(promedio2);
                        Console.WriteLine("Ingrese la opción que desea realizar");
                        Console.WriteLine("1. Estudiante 1: Verificar estado de aprobación");
                        Console.WriteLine("2. Estudiante 1: Agregar nota");
                        Console.WriteLine("3. Estudiante 2: Verificar estado de aprobación");
                        Console.WriteLine("4. Estudiante 2: Agregar nota");
                        Console.WriteLine("5. Salir");
                        opcion = int.Parse(Console.ReadLine());
                        if (opcion == 1)
                        {
                            estudiante1.aprobar(promedio1);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 2)
                        {
                            estudiante1.agregarNota(ref notas1);
                            estudiante1.promedio(notas1, ref promedio1);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 3)
                        {
                            estudiante2.aprobar(promedio2);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 4)
                        {
                            estudiante2.agregarNota(ref notas2);
                            estudiante2.promedio(notas2, ref promedio2);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                        else if (opcion == 5)
                        {
                            Console.WriteLine("Saliendo del ejercicio #3...");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Opción no válida. Ingrese un número válido");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            validacion = true;
                        }
                    } while (validacion);
                    validacion = true;
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa...");
                    validacion = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Número de opción no válida");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    validacion = true;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Opción no válida. Ingrese un número válido");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
        } while (validacion);
    }
}