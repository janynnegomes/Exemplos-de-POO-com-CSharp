using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Notebook:Computador
    {
        float anguloAberturaDisplay;
        
        public Notebook(string _identificacao)
        {
            this.anguloAberturaDisplay = 0;
            this.fabricante = "";
            this.identificacao = _identificacao;
            this.componentes = new List<string>();

            // Adiciona por padrão alguns componentes básicos
            this.componentes.Add("RAM 4GB");
            this.componentes.Add("HD SATA 1TB");
            this.componentes.Add("Placa Mãe Foxconn");
            this.componentes.Add("Processador Core i5");
            this.componentes.Add("Bateria");
            this.componentes.Add("Mousepad");
            this.componentes.Add("Teclado");
            this.componentes.Add("Display LED 23'");
        }
    }
}
