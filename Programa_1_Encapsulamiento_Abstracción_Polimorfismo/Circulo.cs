using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1_Encapsulamiento_Abstracción_Polimorfismo
{
    internal class Circulo : Punto
    {
        Double Radio;
        Double Pi = 3.1416;

        public Double Radio1 { get => Radio; set => Radio = value; }
        public void CalcularArea()
        {
            Double Resultadoa = Pi * Radio1 * Radio1;
            Console.WriteLine("El Area del Circulo es: " + Resultadoa);
        }
        public void CalcularPerimetro()
        {
            Double Resultadop = Pi * Radio1;
            Console.WriteLine("El Perimetro del Circulo es: " + Resultadop);
        }
    }
}
