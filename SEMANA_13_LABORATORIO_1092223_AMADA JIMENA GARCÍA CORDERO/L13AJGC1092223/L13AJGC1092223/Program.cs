using System;
using System.Numerics;

internal class Prgram
{
    static void Main(string[] args)
    {
        //Amada García - 1092223
        Console.WriteLine("Ejercicio No. 01");

        double[] notas = new double[8];
        double suma = 0;
        double notaMasAlta = 0;
        double promedio = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Ingrese la nota del laboratorio #" + (i+1) + ": ");
            notas[i] = Convert.ToDouble(Console.ReadLine());

            suma += notas[i];

            if (notas[i] > notaMasAlta)
            {
                notaMasAlta = notas[i];
            }
        }
        
        promedio = suma / 8;

        Console.WriteLine("El promedio de las notas es: " + promedio);
        Console.WriteLine("La nota más alta es: " + notaMasAlta);

        Console.WriteLine("");
        Console.WriteLine("Ejercicio No. 02");
        Console.ReadKey();

        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        Console.WriteLine("Ingrese una letra:");
        string Letra = Console.ReadLine();

        if (Letra.Length != 1)
        {
            Console.WriteLine("Por favor, ingrese solo una letra.");
            return;
        }

        char letra = Letra[0];

        if (palabra.Contains(Letra))
        {
            Console.WriteLine("\nLa letra " + Letra + " está en la palabra ingresada.");

            if (palabra.IndexOf(Letra) == 0)
            {
                Console.WriteLine("La letra " + letra + " está al principio de la palabra.");
            }
            else
            {
                Console.WriteLine("La letra " + letra + " no está al principio de la " + palabra);
            }

            int cantidadLetra = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    cantidadLetra++;
                }
            }
            Console.WriteLine("La letra " + letra + " aparece " + cantidadLetra + " veces en la palabra.");
        }
        else
        {
            Console.WriteLine("\nLa letra " + letra + " no está en la palabra ingresada.");
        }


    }
}