using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    class Moto:Vehiculo
    {
        private int _cilindrada;

        public Moto(int cilindrada,string patente)
            : base(patente)
        {
            this._cilindrada = cilindrada;
        }
    }
}
