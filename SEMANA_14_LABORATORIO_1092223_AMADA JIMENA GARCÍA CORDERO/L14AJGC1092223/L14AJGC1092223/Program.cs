using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 7 números enteros: ");

        int num = 0;
        int cantPositiva = 0;
        int cantNegativa = 0;
        double numeros = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Número " + (i + 1));
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numeros[i] = num;

                if (num > mayor)
                    mayor = num;
                if (num < menor)
                    menor = num;
                if (num > 0)
                    cantPositiva++;
                else if (num < 0)
                    cantNegativa++;
            }
        }
    }
}