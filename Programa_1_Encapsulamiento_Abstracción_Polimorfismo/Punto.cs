using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1_Encapsulamiento_Abstracción_Polimorfismo
{
    internal class Punto
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
