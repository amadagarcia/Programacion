using System;
using System.Collections.Generic;

class Program
{
    // Amada Jimena García Cordero – 1092223     María Alexandra Sánchez Vargas – 1055323

    static Dictionary<string, int> rutas = new Dictionary<string, int>();

    // Nombres de cada estación y su código
    static Dictionary<int, string> estaciones = new Dictionary<int, string>
    {
        { 51, "Estación Javier" },
        { 61, "Estación Trébol" },
        { 71, "Estación Don Bosco" },
        { 82, "Estación Plaza Municipal" }
    };

    // Dirección de estacion partida a estación destino
    static Dictionary<string, string> rutasNombres = new Dictionary<string, string>
    {
        { "51-61", "Estación Javier a Estación Trébol" },
        { "51-71", "Estación Javier a Estación Don Bosco" },
        { "71-82", "Estación Don Bosco a Estación Plaza Municipal" },
        { "61-51", "Estación Trébol a Estación Javier" },
        { "82-51", "Estación Plaza Municipal a Estación Javier" }
    };

    // Distancia entre las estaciones
    static Dictionary<string, int> distancias = new Dictionary<string, int>
    {
        { "51-61", 14 },
        { "51-71", 28 },
        { "71-82", 13 },
        { "61-51", 7 },
        { "82-51", 21 }
    };

    static void Main(string[] args)
    {
        InicializarRutas();

        Console.WriteLine("¡Bienvenido al sistema de compra de boletos del Trasmetro!");
        decimal totalGastado = 0;
        int tiempoTotalViaje = 0;
        int estacionDestino;
        int estacionPartida;
        string rutaKey;
        Console.ReadKey();

        while (true)
        {
            // Ingreso de datos
            Console.Clear();
            Console.Write("Por favor, ingresa la estación de partida (código): ");
            estacionPartida = int.Parse(Console.ReadLine());
            string nombreEstacionPartida = estaciones.ContainsKey(estacionPartida) ? estaciones[estacionPartida] : "Desconocida";

            Console.Write("Ahora, ingresa la estación de destino (código): ");
            estacionDestino = int.Parse(Console.ReadLine());
            string nombreEstacionDestino = estaciones.ContainsKey(estacionDestino) ? estaciones[estacionDestino] : "Desconocida";

            rutaKey = GenerarRutaKey(estacionPartida, estacionDestino);
            if (rutas.ContainsKey(rutaKey))
            {
                Console.Write("\nIngresa la fecha de tu viaje (AAAA-MM-DD): ");
                DateTime fechaViaje = DateTime.Parse(Console.ReadLine());

                Console.Write("Por favor, dinos tu edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("¿Estás embarazada? (Sí/No): ");
                bool embarazada = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

                Console.Write("¿Viajarás con un niño menor de 3 años? (Sí/No): ");
                bool conNinoMenor = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

                decimal precioBoleto = CalcularPrecioBoleto(distancias[rutaKey], edad, embarazada, conNinoMenor);
                int tiempoViajeEstimado = CalcularTiempoViaje(distancias[rutaKey]);

                // Revelación de datos de boleto a comprar
                Console.Clear();
                Console.WriteLine($"Ruta de partida: {nombreEstacionPartida}");
                Console.WriteLine($"Ruta de destino: {nombreEstacionDestino}");
                Console.WriteLine("Precio del boleto: " + precioBoleto.ToString("C"));
                Console.WriteLine($"Tiempo estimado de viaje: {tiempoViajeEstimado} minutos");

                totalGastado += precioBoleto;
                tiempoTotalViaje += tiempoViajeEstimado;

                Console.ReadKey();
                Console.Clear();
                Console.Write("\n¿Deseas realizar otro viaje? (Sí/No): ");
                string continuarViaje = Console.ReadLine();

                if (!continuarViaje.Equals("Sí", StringComparison.OrdinalIgnoreCase))
                {
                    if (!continuarViaje.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Opción no válida. El programa continuará.");
                    }
                    else
                    {
                        break; //Si se responde a "No" terminar el programa
                    }
                }
            }
            else
            {
                Console.WriteLine("Lo siento, no hay una ruta disponible entre estas estaciones.");
            }
            Console.ReadKey();
        }

        // Boleto comprado
        Console.Clear();
        Console.WriteLine($"Ruta: {rutasNombres[rutaKey]}");
        Console.WriteLine($"Tiempo total viajando: {tiempoTotalViaje} minutos");
        Console.WriteLine($"Total gastado en boletos: {totalGastado.ToString("C")}");
        Console.ReadKey();
    }

    // Rutas posibles
    static void InicializarRutas()
    {
        AgregarRuta(51, 61);
        AgregarRuta(51, 71);
        AgregarRuta(71, 82);
        AgregarRuta(61, 51);
        AgregarRuta(82, 51);
    }

    static void AgregarRuta(int estacionPartida, int estacionDestino)
    {
        string rutaKey = GenerarRutaKey(estacionPartida, estacionDestino);
        rutas.Add(rutaKey, distancias[rutaKey]);
    }

    static string GenerarRutaKey(int estacionPartida, int estacionDestino)
    {
        return $"{estacionPartida}-{estacionDestino}";
    }

    static decimal CalcularPrecioBoleto(int distancia, int edad, bool embarazada, bool conNinoMenor)
    {
        decimal precioBase = distancia <= 10 ? distancia * 0.07m : 10 * 0.07m + (distancia - 10) * 0.02m;
        switch (edad)
        {
            case int n when (n >= 15 && n <= 25):
                return embarazada || conNinoMenor ? 0 : precioBase * 0.79m;
            default:
                return embarazada || conNinoMenor ? 0 : precioBase;
        }
    }

    static int CalcularTiempoViaje(int distancia)
    {
        // Calcula el tiempo en minutos sobre los 40km de la velocidad del transmetro
        return (int)(distancia * 60 / 40);
    }
}