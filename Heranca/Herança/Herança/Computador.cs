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
