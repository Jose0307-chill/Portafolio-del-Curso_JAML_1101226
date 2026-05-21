using System;
class Program
{
    static void Main()
    {
        //El ejercicio #1 comienza aquí
        bool validacion = false;
        int opcion = 0;
        int[,] numeros = new int[5, 5];
        do
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("================ Ejercicio #1 =================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("1. Ejecutar ejercicio #1");
            Console.WriteLine("2. Siguiente ejercicio");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                llenar(numeros);
                Console.WriteLine("La suma de la diagonal principal es: " + sumaPrincipal(numeros));
                Console.WriteLine("La suma de la diagonal secundaria es: " + sumaSecundaria(numeros));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
            else if (opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para pasar al ejercicio #2");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: opción no válida, por favor intente de nuevo.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
        } while (validacion);
        //El ejercicio #2 comienza aquí
        int[,] ParImpar = new int[4, 6];
        do
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("================ Ejercicio #2 =================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("1. Ejecutar ejercicio #2");
            Console.WriteLine("2. Siguiente ejercicio");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                llenar(ParImpar);
                Console.WriteLine("Hay " + Par(ParImpar) + " números pares");
                Console.WriteLine("Hay " + Impar(ParImpar) + " números impares");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
            else if (opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para pasar al ejercicio #3");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: opción no válida, por favor intente de nuevo.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }

        } while (validacion);
        //El ejercicio #3 comienza aquí
        bool auxiliar = false;
        string respuesta;
        float[,] notas = new float[5, 4];
        do
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("================ Ejercicio #3 =================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("1. Ejecutar ejercicio #3");
            Console.WriteLine("2. Siguiente ejercicio");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                llenarNotas(notas);
                do
                {
                    Console.WriteLine("¿Desea ver el promedio de algún estudiante? (S/N)");
                    respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "S")
                    {
                        Console.WriteLine("Ingrese el número del estudiante que desea ver su promedio: ");
                        int estudiante = int.Parse(Console.ReadLine());
                        if (estudiante >= 1 && estudiante <= 5)
                        {
                            Console.WriteLine("El promedio del estudiante " + estudiante + " es: " + promedioEstudiante(notas, estudiante));
                            float promedio = promedioEstudiante(notas, estudiante);
                            Console.WriteLine("Estado: " + aprobacion(promedio));
                            auxiliar = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: número de estudiante no válido, por favor intente de nuevo.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ResetColor();
                            Console.ReadLine();
                            Console.Clear();
                            auxiliar = true;
                        }
                    }
                    else if (respuesta == "N")
                    {
                        auxiliar = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: respuesta no válida, por favor ingrese S o N.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ResetColor();
                        auxiliar = true;
                    }
                } while (auxiliar);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
            else if (opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para pasar al ejercicio #4");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: opción no válida, por favor intente de nuevo.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
        } while (validacion);
        //El ejercicio #4 comienza aquí
        int[,] simetrica = new int[3, 3];
        do
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("================ Ejercicio #4 =================");
            Console.WriteLine("===============================================");
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("1. Ejecutar ejercicio #4");
            Console.WriteLine("2. Salir del Laboratorio #12");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                llenar(simetrica);
                Console.WriteLine("La matriz " + simetria(simetrica) + " respecto al eje Y");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
            else if (opcion == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Console.ResetColor();
                validacion = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: opción no válida, por favor intente de nuevo.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Presione ENTER para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                validacion = true;
            }
        } while (validacion);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Gracias por ejecutar el programa, hasta la próxima!");
        Console.ResetColor();
    }
    //Métodos del ejercicio #1 (también se utiliza en el ejercicio #2 y #4)
    static void llenar(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Ingrese el número para la posicion: " + (i, j));
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("La matriz ingresada es la siguiente: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static int sumaPrincipal(int[,] numeros)
    {
        int suma = 0;
        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                if (i == j)
                {
                    suma += numeros[i, j];
                }
            }
        }
        return suma;
    }
    static int sumaSecundaria(int[,] numeros)
    {
        int suma = 0;
        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                if (i + j == numeros.GetLength(0) - 1)
                {
                    suma += numeros[i, j];
                }
            }
        }
        return suma;
    }
    //Métodos del ejercicio #2
    static int Par(int[,] matriz)
    {
        int par = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    par++;
                }
            }
        }
        return par;
    }
    static int Impar(int[,] matriz)
    {
        int impar = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 != 0)
                {
                    impar++;
                }
            }
        }
        return impar;
    }
    //Métodos del ejercicio #3
    static void llenarNotas(float[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + " para la materia " + (j + 1));
                matriz[i, j] = float.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Las notas ingresadas son las siguientes: ");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("Estudiante " + (i + 1) + ": ");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static float promedioEstudiante(float[,] matriz, int estudiante)
    {
        float promedio = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            promedio += matriz[estudiante - 1, j];
        }
        promedio /= matriz.GetLength(1);
        return promedio;
    }
    static string aprobacion(float prom)
    {
        if (prom >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }
    //Métodos del ejercicio #4
    static string simetria(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1) / 2; j++)
            {
                if (matriz[i, j] != matriz[i, matriz.GetLength(1) - 1 - j])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "no es simétrica";
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        return "es simétrica";
    }
}