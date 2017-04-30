using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Conversor
    {
        public static string EnteroBinario(int numero)
        {
            string retorno = "";
            byte ascii=0;
            ascii = Convert.ToByte(numero);
            return retorno;
        }
        public static int BinarioDecimal(String numero)
        {
            int retorno = 0;
            retorno = Convert.ToInt32(numero);
            return retorno;
        }
    }
}
