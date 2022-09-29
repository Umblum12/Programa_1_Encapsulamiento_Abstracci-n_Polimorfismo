using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1_Encapsulamiento_Abstracción_Polimorfismo
{
    internal class Linea : Punto
    {
        int PuntoIncial;
        int PuntoFinal;

        public int PuntoIncial1 { get => PuntoIncial; set => PuntoIncial = value; }
        public int PuntoFinal1 { get => PuntoFinal; set => PuntoFinal = value; }
        public void CalcularArea()
        {
           int Resultadoa = PuntoIncial1 + PuntoFinal1;
            Console.WriteLine("El Area del la Linea es: " + Resultadoa);
        }
        public void CalcularPerimetro()
        {
            int Resultadop = PuntoIncial1 * PuntoFinal1;
            Console.WriteLine("El Perimetro del la Linea es: " + Resultadop);
        }
    }
}
