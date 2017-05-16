using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Estacionamiento
    {
        private string _nombre;
        private List<Vehiculo> _misVehiculos;

        private Estacionamiento()
        {
            this._misVehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre)
            : this()
        {
            this._nombre = nombre;
        }
        public static bool operator ==(Estacionamiento y,Vehiculo x)
        {
            foreach (Vehiculo item in y._misVehiculos)
            {
                if (item == x)
                    return true;
            }
            return false;

        }
        public static bool operator !=( Estacionamiento y,Vehiculo x)
        {
            foreach (Vehiculo item in y._misVehiculos)
            {
                if (x != item)
                    return true;                
            }
            return false;          
        }
        public override bool Equals(object obj)
        {
            if (obj is Vehiculo)
                return true;
            return false;            
        }
        public static Estacionamiento operator +(Estacionamiento y, Vehiculo x)
        {
            if (y != x)
                y._misVehiculos.Add(x);
            return y;
        }
        public static Estacionamiento operator-(Estacionamiento y, Vehiculo x)
        {

        }


    }
}

