using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuadrarCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            Console.WriteLine("Ingrese una cadena a recuadrar con asteriscos");
            cadena = Console.ReadLine();
            Recuadrar facultad = new Recuadrar();
            facultad.recuadrar(cadena);
        }
    }
}
