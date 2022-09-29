using Programa_1_Encapsulamiento_Abstracción_Polimorfismo;

namespace Programa_1_Encapsulamiento_Abstracción_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" :------------------------------: ");
            Console.WriteLine(" :------------------------------: ");
            Linea linea = new Linea();
            Console.WriteLine("Introduce El punto Inicial: ");
            linea.PuntoIncial1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce El punto Final: ");
            linea.PuntoFinal1 = Int32.Parse(Console.ReadLine());
            linea.CalcularArea();
            linea.CalcularPerimetro();
            Console.WriteLine(" :------------------------------: ");
            Console.WriteLine(" :------------------------------: ");
            Circulo criculo = new Circulo();
            Console.WriteLine("Introduce El Radio: ");
            criculo.Radio1 = Double.Parse(Console.ReadLine());
            criculo.CalcularArea();
            criculo.CalcularPerimetro();
            Console.WriteLine(" :------------------------------: ");
            Console.WriteLine(" :------------------------------: ");
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine("Introduce El Ancho: ");
            rectangulo.Ancho1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce La Altura: ");
            rectangulo.Altura1 = Int32.Parse(Console.ReadLine());
            rectangulo.CalcularArea();
            rectangulo.CalcularPerimetro();
            Console.WriteLine(" :------------------------------: ");
            Console.WriteLine(" :------------------------------: ");
            Console.ReadKey(true);
        }
    }
}