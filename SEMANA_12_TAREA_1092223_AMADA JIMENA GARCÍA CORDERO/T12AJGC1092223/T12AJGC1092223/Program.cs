using System;

class Program
{
    static void Main(string[] args)
    {
        //Amada García - 1092223
        Circulo objCirculo;

        Console.WriteLine("Ingrese el radio del círculo (centímetros): ");
        double radio = Convert.ToDouble(Console.ReadLine());
        objCirculo = new Circulo(radio);

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro: " + perimetro + " centímetros");
        Console.WriteLine("Área: " + area + " cm^2");
        Console.WriteLine("Volumen: " + volumen + " cm^3");


        TrianguloRectangulo objTriangulo;
        Console.WriteLine("Ingrese la longitud del cateto del triángulo (en metros):");
        double longitudCateto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la amplitud en grados del ángulo opuesto al cateto:");
        double anguloOpuesto = Convert.ToDouble(Console.ReadLine());
        objTriangulo = new TrianguloRectangulo(longitudCateto, anguloOpuesto);

        Console.WriteLine("Valor de cateto A: " + objTriangulo.ObtenerCatetoA() + " metros");
        Console.WriteLine("Valor de cateto B: " + objTriangulo.ObtenerCatetoB() + " metros");
        Console.WriteLine("Valor de hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " metros");
        Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
        Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
        Console.WriteLine("Valor de área: " + objTriangulo.ObtenerArea() + " m^2");


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
    class TrianguloRectangulo
    {
        private double catetoA;
        private double anguloOpuestoA;

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        public double ObtenerCatetoB()
        {
            double anguloOpuestoRad = anguloOpuestoA * Math.PI / 180; // Convertir a radianes
            double catetoB = catetoA / Math.Tan(anguloOpuestoRad);
            return Math.Round(catetoB, 3);
        }

        public double ObtenerHipotenusa()
        {
            double anguloOpuestoRad = anguloOpuestoA * Math.PI / 180; 
            double hipotenusa = catetoA / Math.Sin(anguloOpuestoRad);
            return Math.Round(hipotenusa, 3);
        }

        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        public double ObtenerAnguloOpuestoB()
        {
            double anguloB = 90 - anguloOpuestoA;
            return Math.Round(anguloB, 3);
        }

        public double ObtenerArea()
        {
            double catetoB = ObtenerCatetoB();
            double area2 = 0.5 * catetoA * catetoB;
            return Math.Round(area2, 3);
        }
    }
}