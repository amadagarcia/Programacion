using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre2 = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        string Edad = Console.ReadLine();
        Console.WriteLine("Ingrese su carrera: ");
        string Carrera = Console.ReadLine();
        Console.WriteLine("Ingrese su carné: ");
        string Carné = Console.ReadLine();
        /*COMENTARIOS;*/
        Console.Write("Nombre: " + Nombre2);
        Console.Write(" Edad: " + Edad);
        Console.Write(" Carrera: " + Carrera);
        Console.Write(" Carné: " + Carné);

        Console.WriteLine(" Soy " + Nombre2 + " Tengo " + Edad + " años y estudio la carrera de " + Carrera + "."); 
        Console.WriteLine("Mi número de carné es: " + Carné);

        Console.ReadKey();
    }
}