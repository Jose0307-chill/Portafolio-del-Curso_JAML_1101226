using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Timers;

namespace L14_JAML_1101226
{
    internal class Estudiante
    {
        string nombre;
        int edad;
        string grado;
        double[] notas = new double[3];
        public Estudiante(string nombre, int edad, string grado, double[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }
        public void promedio(double[] arreglo, ref double promedio) 
        {
            double suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }
            promedio = suma / arreglo.Length;
            Console.WriteLine("El promedio del estudiante es: " + promedio);
        }
        public void mostrarInformacionEstudiante(double promedio)
        {
            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);
            Console.WriteLine("Notas");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota " + (i + 1) + ": " + notas[i]);
            }
            Console.WriteLine("Promedio: " + promedio);
        }
        public void aprobar(double promedio)
        {
            if (promedio >= 61)
            {
                Console.WriteLine("El estudiante aprobó el grado.");
            }
            else
            {
                Console.WriteLine("El estudiante no aprobó el grado.");
            }
        }
        public void agregarNota(ref double[] arreglo)
        {
            Console.WriteLine("Ingrese la nueva nota:");
            double nuevaNota = double.Parse(Console.ReadLine());
            if (nuevaNota >= 0 && nuevaNota <= 100)
            {
                Array.Resize(ref arreglo, arreglo.Length + 1);
                arreglo[arreglo.Length - 1] = nuevaNota;
                notas = arreglo;
                Console.WriteLine("Nota agregada exitosamente.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nota no válida. Debe estar entre 0 y 100.");
                Console.ResetColor();
            }
        }
    }
}
