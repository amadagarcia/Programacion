using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratorio 8");
        Console.WriteLine("\nIngresar un número: ");
        
        int N = Convert.ToInt32(Console.ReadLine());
       
        string resultado = "";
        int A = 0; 
        int B = 1; 
        int C = 0; 
        int i = 2;

        if (N > 0) 
        { 
            resultado = A.ToString();
            Console.WriteLine("Resultado: " + A);
            if (N > 1)
            {
                resultado += B.ToString();
                 
                while (i < N) 
                {
                    C = A + B; 
                    resultado += C.ToString();
                    A = B;
                    B = C;
                    i++;
                }

                Console.WriteLine("Resultado: " + resultado);

            }
            else 
            { 
                Console.WriteLine("Resultado: " + resultado);
            }
            
        }
        else 
        { 
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}