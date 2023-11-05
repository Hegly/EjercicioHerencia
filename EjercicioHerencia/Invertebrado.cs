using System;
namespace EjercicioHerencia
{
    internal class Invertebrado : Animal
	{
        public string? tipo;
        public bool tienePatas;
        public int numeroPatas;
        public bool tieneConcha;

        public void imprimirInvertebrado()
        {
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("Número de Patas: " + numeroPatas);
            Console.WriteLine("Tiene Concha: " + tieneConcha);
            Console.WriteLine();
        }
    }
}

