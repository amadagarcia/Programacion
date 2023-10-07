using System;

class Program
{
    static void Main(string[] args)
    //Amada García - 1092223
    {
        Console.WriteLine("Tarea 9");
        Console.WriteLine("Primera operación");
        Console.Write("Ingrese un número entero mayor a 0: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("ERROR: El número que ingrese debe ser un entero mayor a 0.");
        }
        else
        {
            double suma1 = 0.0;
            int a = 1;

            while (a <= numero)
            {
                suma1 += 1.0 / a;
                a++;
            }
            Console.WriteLine("El resultado de la primera operación es: " + suma1);
        }

        Console.WriteLine("Segunda operación");
        if (numero <= 0)
        {
            Console.WriteLine("ERROR: El número que ingrese debe ser un entero mayor a 0");
        }
        else
        {
            double suma2 = 0.0;

            for (int b = 1; b <= numero; b++)
            {
                suma2 += 1.0 / Math.Pow(2, b);

            }
            Console.WriteLine("El resultado de la segunda operación es: " + suma2);
        }
    }
}