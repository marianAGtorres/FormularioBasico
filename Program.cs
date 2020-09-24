using System;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Hola, Ingresa los siguienetes datos, para realizar tu registro");
            Console.Write("Ingrese su edad:  ");
            a = int.Parse(Console.ReadLine());
            if (a >= 18 )
            {
                Console.WriteLine("Bienvenido  tu registro ha sido Exitoso!");

            }
            else
            {
                Console.WriteLine("Lo sentimos por ser menor de edad no puedes continuar");
            }

        }
    }
}
