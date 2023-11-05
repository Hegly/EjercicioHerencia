﻿using System;
using System.Drawing;

namespace EjercicioHerencia
{
    public class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

        /**para imprimir datos**/

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);
        }

        /**para validar datos**/

        public bool validar()
        {
            if (nombre != null && color != null && tamano != null && familia != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}

