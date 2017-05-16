using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public abstract class Vehiculo
    {
        protected string _patente;

        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        public static bool operator ==(Vehiculo x, Vehiculo y)
        {
            if (x._patente == y._patente)
                return true;
            return false;
        }

        public static bool operator !=(Vehiculo x, Vehiculo y)
        {
            return !(x == y);             
        }


    }
}
