using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Auto:Vehiculo
    {
        private int _cantidadDePuertas;

        public Auto (int cantidadDePuertas, string patente):base(patente)
        {
            this._cantidadDePuertas=cantidadDePuertas;
        }

    }
}
