using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratorio 9");
        Console.WriteLine("Ejercicio #1");
        Console.WriteLine("\nIngrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = 1;
        int sumatoria = 0;

        while (contador <= numero)
        {
            sumatoria = sumatoria + contador;
            contador++;

        }

        Console.WriteLine("Resultado: " + sumatoria);
        Console.ReadKey();

        Console.WriteLine("Ejercicio #2");
        Console.WriteLine("FOR");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nTabla del " + i + ":\t");
            for (int j = 1; j <= numero; j++)
            {
                Console.Write(i * j + "\t");
            }
        }
        Console.ReadLine();
    }
}