using System;

namespace MRUV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Movimiento Rectilíneo Uniformemente Variado");
            Console.WriteLine("\n Vf = Vo + at.");
            Console.WriteLine("\n Vf = Velocidad final ");
            Console.WriteLine("\n Vo = Velocidad inicial ");
            Console.WriteLine("\n a = Aceleracion ");
            Console.WriteLine("\n t = tiempo");



            Console.Write("\nIngrese la velocidad final (V) o 'X' si no la conoce: ");
            string velocidadFinalInput = Console.ReadLine();

            Console.Write("\nIngrese la velocidad inicial (Vo) o 'X' si no la conoce: ");
            string velocidadInicialInput = Console.ReadLine();

            Console.Write("\nIngrese la aceleración (a) o 'X' si no la conoce: ");
            string aceleracionInput = Console.ReadLine();

            Console.Write("\nIngrese el tiempo (t) o 'X' si no la conoce: ");
            string tiempoInput = Console.ReadLine();
            double? velocidadFinal = ParseInput(velocidadFinalInput);
            double? velocidadInicial = ParseInput(velocidadInicialInput);
            double? aceleracion = ParseInput(aceleracionInput);
            double? tiempo = ParseInput(tiempoInput);


            int variablesIngresadas = 0;
            if (velocidadFinal != null)
                variablesIngresadas++;
            if (velocidadInicial != null)
                variablesIngresadas++;
            if (aceleracion != null)
                variablesIngresadas++;
            if (tiempo != null)
                variablesIngresadas++;

            if (variablesIngresadas == 3)
            {
                if (velocidadFinal == null)
                {
                    velocidadFinal = velocidadInicial + (aceleracion * tiempo);
                }
                else if (velocidadInicial == null)
                {
                    velocidadInicial = velocidadFinal - (aceleracion * tiempo);
                }
                else if (aceleracion == null)
                {
                    aceleracion = (velocidadFinal - velocidadInicial) / tiempo;
                }
                else if (tiempo == null)
                {
                    tiempo = (velocidadFinal - velocidadInicial) / aceleracion;
                }

                Console.WriteLine($"\nVelocidad Final (V): {velocidadFinal}");
                Console.WriteLine($"Velocidad Inicial (Vo): {velocidadInicial}");
                Console.WriteLine($"Aceleración (a): {aceleracion}");
                Console.WriteLine($"Tiempo (t): {tiempo}");
            }
            else
            {
                Console.WriteLine("ERROR: Debe ingresar almenos 3 de las 4 variables.");
            }

            Console.ReadLine();
        }

        static double? ParseInput(string input)
        {
            if (input.ToUpper() == "X")
            {
                return null;
            }
            else
            {
                return Convert.ToDouble(input);
            }
        }
    }
}
