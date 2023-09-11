
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2");
        int día;
        string entrada;

        Console.WriteLine("Ingresar un número del 1 al 7");
        entrada = Console.ReadLine();
        día = Int32.Parse(entrada);

        if (día >= 1 && día <=7) 
        {
            if (día == 1) 
            {
                Console.WriteLine("Día: Lunes");
            }

            if (día == 2) 
            {
                Console.WriteLine("Día: Martes");
            }
            if (día == 3) 
            {
                Console.WriteLine("Día: Miércoles");
            }
            if (día == 4) 
            {
                Console.WriteLine("Día: Jueves");
            }
            if (día == 5) 
            {
                Console.WriteLine("Día: Viernes");
            }
            if (día == 6) 
            {
                Console.WriteLine("Día: Sábado");
            }
            if (día == 7) 
            {
                Console.WriteLine("Día: Domingo");
            }
        }
        else
        {
            Console.WriteLine("ERROR: Por favor ingrese un número que se encuentre en el rango de 1 a 7");
        }

        Console.ReadKey();

    }
}