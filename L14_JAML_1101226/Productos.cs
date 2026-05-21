using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace L14_JAML_1101226
{
    internal class Producto
    {
        string nombre;
        double precio;
        int cantidad;
        public Producto(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public void mostrarInformacionProducto()
        {
            Console.WriteLine("Nombre del producto: " + nombre);
            Console.WriteLine("Precio: Q" + precio);
            Console.WriteLine("Cantidad: " + cantidad);
        }
        public void vender(ref double dinero)
        {
            Console.WriteLine("El precio del producto es de: " + precio);
            Console.WriteLine("Ingrese la cantidad a vender:");
            int venta = int.Parse(Console.ReadLine());
            if (venta > 0 && venta <= cantidad)
            {
                cantidad -= venta;
                double totalVenta = venta * precio;
                dinero =  dinero + totalVenta;
                Console.WriteLine("Venta exitosa. Total: Q" + totalVenta);
                Console.WriteLine("Cantidad restante del prodcuto: " + cantidad);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cantidad de venta no válida o stock insuficiente.");
                Console.ResetColor();
            }
        }
        public void reabastecer()
        {
            Console.WriteLine("La cantidad actual del producto es de: " + cantidad);
            Console.WriteLine("Ingrese la cantidad a reabastecer:");
            int reabastecimiento = int.Parse(Console.ReadLine());
            if (reabastecimiento > 0)
            {
                cantidad += reabastecimiento;
                Console.WriteLine("Reabastecimiento exitoso. Nueva cantidad: " + cantidad);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cantidad de reabastecimiento no válida.");
                Console.ResetColor();
            }
        }
    }
}