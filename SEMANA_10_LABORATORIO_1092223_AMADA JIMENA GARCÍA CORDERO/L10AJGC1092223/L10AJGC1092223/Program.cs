using System;

class Program
{
    static void Main(string[] args)
    {
        //Amada García - 1092223

        Automovil automovil_1 = new Automovil();

        Console.WriteLine("Modelo: " + automovil_1.modelo);
        Console.WriteLine("Precio: " + automovil_1.precio);
        Console.WriteLine("Marca: " + automovil_1.marca);
        Console.WriteLine("Disponible: " + automovil_1.disponible);
        Console.WriteLine("Tipo de Cambio de Dolar: " + automovil_1.tipoCambioDolar);
        Console.WriteLine("Descuento Aplicado: " + automovil_1.descuentoAplicado);

        Console.ReadLine();
    }
}
public class Automovil
{
        public int modelo { get; set; }
        public double precio { get; set; }
        public string marca { get; set; }
        public bool disponible { get; set; }
        public double tipoCambioDolar { get; set; }
        public double descuentoAplicado { get; set; }

    public Automovil()
    {
        this.modelo = 2019;
        this.precio = 10000.00;
        this.marca = "";
        this.disponible = false;
        this.tipoCambioDolar = 7.50;
        this.descuentoAplicado = 0.00;
    }
}