using System;
class Program
{
    static void Main()
    {
        int cantidadPartidas = 0;
        int cantidadTiros = 0;

        Console.WriteLine("Bienvenido al juego de dados. \nPor favor, ingrese la cantidad de partidas que va a jugar:");
        cantidadPartidas = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Ingrese la cantidad de tiros por partida: SOLO VALORES PARES");
            cantidadTiros = Convert.ToInt32(Console.ReadLine());

            if (cantidadTiros % 2 != 0)
            {
                Console.WriteLine("ERROR. El valor de tiros por partidas ingresado es impar. Por favor ingresa un valor par.");
            }
        }
        while (cantidadTiros % 2 != 0);

        if (cantidadTiros % 2 == 0)
        {
            int ganadasJugador = 0;
            int ganadasCasa = 0;
            int partida = 0;
            Random random = new Random();

            for (partida = 0; partida < cantidadPartidas; partida++)
            {
                int puntosJugador = 0;
                int puntosCasa = 0;
                int puntosFinalJugador = 0;
                Console.WriteLine("\nPartida #" + (partida + 1) + ": ");

                for (int tiro = 0; tiro < cantidadTiros; tiro++)
                {
                    int dado1 = random.Next(1, 7); //Dados del Jugador
                    int dado2 = random.Next(1, 7); //Dados del Jugador
                    int dado3 = random.Next(1, 7); //Dados de la Casa
                    int dado4 = random.Next(1, 7); //Dados de la Casa
                    int sumaDados1 = dado1 + dado2;
                    int sumaDados2 = dado3 + dado4;
                    int tirosImpares = 0;
                    int tirosPares = 0;
                    int tirosIguales = 0;
                    double tirosGanadosJugador = 0;

                    Console.WriteLine("\nTiro #" + (tiro + 1) + " del jugador" + ": \nDado 1: " + dado1 + "\nDado 2: " + dado2 + "\nSuma: " + sumaDados1);
                    Console.WriteLine("\nTiro #" + (tiro + 1) + " de la casa" + ": \nDado 1: " + dado3 + "\nDado 2: " + dado4 + "\nSuma: " + sumaDados2);

                    //Aquí establecí las restricciones del juego
                    if (tiro == 1 && (sumaDados1 == 6 || sumaDados1 == 12))
                    {
                        puntosJugador += 12;
                        tirosGanadosJugador++;
                    }

                    else if (tiro == 1 && (sumaDados2 == 4 || sumaDados2 == 10))
                    {
                        puntosCasa += 12;
                    }
                    else if (tiro == 1 && (sumaDados1 == 2) || (sumaDados1 == 3) || (sumaDados1 == 5) || (sumaDados1 == 7) || (sumaDados1 == 8) || (sumaDados1 == 9) 
                        || (sumaDados2 == 2) || (sumaDados2 == 3) || (sumaDados2 == 5) || (sumaDados2 == 7) || (sumaDados2 == 8) || (sumaDados2 == 9))
                    {
                        puntosCasa += sumaDados2;
                        puntosJugador += sumaDados1;
                        tirosGanadosJugador++;
                    }
                    else if (tiro > 1 && (sumaDados1 == 11) || (sumaDados2 == 11))
                    {
                        puntosCasa += 6;
                        puntosJugador += 0;
                        tirosGanadosJugador++;
                    }

                    //Esto es para ver la cantidad de tiros pares, impares e iguales
                    if (sumaDados1 % 2 == 0)
                    {
                        tirosPares++;
                    }
                    else
                    {
                        tirosImpares++;
                    }
                    if (dado1 == dado2)
                    {
                        tirosIguales++;
                    }

                    if (sumaDados2 % 2 == 0)
                    {
                        tirosPares++;
                    }
                    else
                    {
                        tirosImpares++;
                    }
                    if (dado3 == dado4)
                    {
                        tirosIguales++;
                    }

                    //Resultados
                    if (puntosJugador > puntosCasa)
                    {
                        tirosGanadosJugador++;
                        Console.WriteLine("\n¡El jugador gana esta partida!");
                    }
                    else if (puntosJugador < puntosCasa)
                    {
                        ganadasCasa++;
                        Console.WriteLine("\n¡La casa gana esta partida!");
                    }
                    else if (puntosCasa == puntosJugador)
                    {
                        Console.WriteLine("\n¡Empate!");
                    }

                    double probabilidadGanar = (double)tirosGanadosJugador / cantidadTiros * 100;

                    Console.WriteLine("\nRESULTADOS");
                    Console.WriteLine("Tiros ganados por el jugador: " + tirosGanadosJugador);
                    Console.WriteLine("Probabilidad de ganar: " + probabilidadGanar.ToString("0.##") + "%");
                    Console.WriteLine("Tiros en los que los números fueron pares: " + tirosPares);
                    Console.WriteLine("Tiros en los que los números fueron impares: " + tirosImpares);
                    Console.WriteLine("Tiros en los que los números fueron iguales:" + tirosIguales);
                    Console.WriteLine("Puntaje del jugador: " + puntosJugador);

                    puntosFinalJugador += puntosJugador;
                }

                if (ganadasCasa < ganadasJugador)
                {
                    Console.WriteLine("\nGana el Jugador");
                }
                else
                {
                    Console.WriteLine("\nGana la Casa");
                }

                Console.WriteLine("Puntaje Final del jugador: " + puntosFinalJugador);
            }
        }
    }
}