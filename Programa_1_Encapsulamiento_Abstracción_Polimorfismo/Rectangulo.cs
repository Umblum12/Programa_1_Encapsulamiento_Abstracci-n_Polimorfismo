using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1_Encapsulamiento_Abstracción_Polimorfismo
{
    internal class Rectangulo : Punto
    {
        int Ancho;
        int Altura;

        public int Ancho1 { get => Ancho; set => Ancho = value; }
        public int Altura1 { get => Altura; set => Altura = value; }

        public void CalcularArea()
        {
            int resultado4 = Ancho1 * Altura1;
            Console.WriteLine("El Area del Rectangulo es: " + resultado4);
        }
        public void CalcularPerimetro()
        {
            int resultado5 = Ancho1 + Altura1 + Ancho1 + Altura1;
            Console.WriteLine("El Perimetro del Rectangulo es: " + resultado5);
        }
    }
}
