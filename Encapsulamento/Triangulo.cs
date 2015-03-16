using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Triangulo
    {
        public float Lado_A { get; set; }
        public float Lado_B { get; set; }
        public float Lado_C { get; set; }
        public string Cor { get; set; }
        public int Area
        {
            get{
                return 0;
            }

            set
            {

                // Inserir aqui o calculo
            }
        }

    }
}
