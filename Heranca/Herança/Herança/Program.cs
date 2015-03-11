using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador pcJanynne = new Computador("Lenovo-Janynne");

            pcJanynne.Ligar();

            pcJanynne.ListarComponentes();

            Notebook notebookJanynne = new Notebook("Ideapad-Janynne");

            notebookJanynne.Ligar();
            notebookJanynne.ListarComponentes();

            Console.ReadKey();
        }
    }
}
