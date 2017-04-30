using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Program
    {
        /// <summary>
        /// Desarrollar una clase llamada Conversor.
        /// 1. Deberá poseer dos métodos de clase(estáticos):
        /// A. string EnteroBinario(int). Convierte un número 
        /// de entero a binario ascii(un caracter por bit, 
        /// siendo “111” el equivalente al número 7).
        /// B. double BinarioDecimal(string). Convierte un
        /// número binario a decimal.
        /// 2. El en Main generar un menú para que el usuario 
        /// elija que tipo de conversión desea realizar o si desea
        /// salir del programa.Luego de elegir una opción, le deberá 
        /// pedir que ingrese el número a convertir y mostrarle el
        /// resultado por pantalla; al presionar cualquier tecla retornar al menu.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int opcion = 0;
            char salir = 'n';
            int numero = 0;
            string auxiliar = "";

            do
            {
                Console.Clear();
                Console.WriteLine("1-Convertir de Binario a Entero");
                Console.WriteLine("2-Convertir de Entero a Binario");
                Console.WriteLine("3-Salir");
                opcion = Console.Read();
                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Ingrese un valor Binario ASCII a convertir a Entero:");
                        auxiliar = Console.ReadLine();
                        numero = Conversor.BinarioDecimal(auxiliar);
                        Console.WriteLine(auxiliar);
                        Console.WriteLine(numero);
                        Console.Read();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Ingrese un valor Entero a convertir a Binario");
                        numero = Console.Read();
                        auxiliar = Conversor.EnteroBinario(numero);
                        Console.WriteLine(numero);
                        Console.WriteLine(auxiliar);
                        Console.Read();

                        break;
                    case '3':
                        Console.Clear();
                        salir = 's';
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.Read();
                        break;
                }



            } while (salir=='n');
            
        }
    }
}
