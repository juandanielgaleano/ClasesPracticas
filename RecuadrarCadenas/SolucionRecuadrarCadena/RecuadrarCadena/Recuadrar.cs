using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuadrarCadena
{
    public class Recuadrar
    {
        public void recuadrar(string cadena)
        {
            int largo = 0;
            largo = cadena.Length;
            string asteriscos = "*";
            string recuadro = "*";
            for (int i = 0; i < largo; i++)
            {
                recuadro = recuadro + asteriscos;
            }
            Console.WriteLine(recuadro + "*");
            Console.WriteLine("*" + cadena + "*");
            Console.WriteLine(recuadro + "*");
            Console.ReadKey();
        }
    }
}
