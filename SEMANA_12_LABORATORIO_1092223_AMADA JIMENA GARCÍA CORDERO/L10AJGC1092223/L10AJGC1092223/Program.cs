using System;

class Program
{
    static void Main(string[] args)
    {
        //Amada García - 1092223
        Circulo objCirculo;

        Console.WriteLine("Ingrese el radio del círculo (cm): ");
        double radio = Convert.ToDouble(Console.ReadLine());
        objCirculo = new Circulo(radio);

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro: " + perimetro + " cm");
        Console.WriteLine("Área: " + area + " cm^2");
        Console.WriteLine("Volumen: " + volumen + " cm^3");

    }

    class Circulo
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        private double ObtenerPerimetro()
        {
            return 2 * 3.1416 * radio;
        }

        private double ObtenerArea()
        {
            return 3.1416 * radio * radio;
        }

        private double ObtenerVolumen()
        {
            // La fórmula para el volumen de una esfera es (4/3) * pi * radio^3
            return (4.0 / 3.0) * 3.1416 * radio * radio * radio;
        }

        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro();
            unArea = ObtenerArea();
            unVolumen = ObtenerVolumen();
        }
    }
}