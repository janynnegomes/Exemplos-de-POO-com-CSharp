using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    // Nome da classe
    class Computador
    {
        // Armazena a lista de componentes que o computador possui
        List<string> componentes;

        string fabricante;
        string identificacao;

        // Método construtor
        public Computador(string _identificacao)
        {
            this.identificacao = _identificacao;

            // Inicializa a variável
            this.componentes = new List<string>();

            // Adiciona por padrão alguns componentes básicos
            this.componentes.Add("RAM 1GB");
            this.componentes.Add("HD SATA 1TB");
            this.componentes.Add("HD Serial 200GB");
            this.componentes.Add("Placa Mãe Foxconn");
            this.componentes.Add("Processador Core 2 Duo");
            this.componentes.Add("Fonte");
            this.componentes.Add("Mouse USB");
            this.componentes.Add("Teclado USB");
            this.componentes.Add("Monitor LED 23'");
        }

        public void Formatar() 
        {
            // Aqui você implementa seu código

        }

        public void Ligar() {
            
            Console.WriteLine("Computador "+this.identificacao+" ligado...");
        }

        public void Desligar() {

            Console.WriteLine("Computador " + this.identificacao + " desligado...");
        }

        public void Reiniciar() {

            this.Desligar();
            this.Ligar();
            
        }
    }
}
