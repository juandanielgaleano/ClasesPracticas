using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// 1. Generar un nuevo programa que realice las siguientes acciones:
        /// A.Ingresar 5 números enteros por consola, guardándolos en 5 
        /// variables escalares.Luego calcular y mostrar: el valor máximo, 
        /// el valor mínimo y el promedio.
        /// 2. Siendo la definición de número primo “un número natural mayor 
        /// que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.”:
        /// A.Mostrar por pantalla todos los números primos que haya hasta 
        /// el número que ingrese el usuario por consola.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            int numero = 0;
            string auxiliar="";
            int acumulador = 0;
                        
            
            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese un numero entero: ");
                auxiliar=Console.ReadLine();
                int.TryParse(auxiliar,out numero);

                if (contador==0 || numero<minimo)
                {
                    minimo = numero;
                }
                if(contador==0 || numero>maximo)
                {
                    maximo = numero;
                }
                acumulador = acumulador + numero;
            }
            Console.WriteLine("El numero maximo es " + maximo);
            Console.WriteLine("El numero minimo es " + minimo);
            promedio = (float)acumulador / 5;
            Console.WriteLine("El promedio es :" + promedio);
            Console.ReadKey();
        }
    }
}
