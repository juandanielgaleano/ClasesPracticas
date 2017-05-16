using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento;

namespace PracticaParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento.Estacionamiento miEstacionamiento = new Estacionamiento.Estacionamiento("uno");
            Auto auto=new Auto(5,"A1");
            miEstacionamiento = miEstacionamiento + auto;
            
        }
    }
}
