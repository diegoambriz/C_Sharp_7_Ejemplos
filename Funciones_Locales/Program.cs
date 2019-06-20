using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Locales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 3: Funciones locales
            int numeroApromediar;
            int suma = 0;
            int cont = 0;
            Console.WriteLine("Ingresa enteros para calcular promedio. Presiona 0 para finalizar. ");
            do
            {
                numeroApromediar = int.Parse(Console.ReadLine());
                suma += numeroApromediar;
                cont++;
            }
            while (numeroApromediar != 0);
            //CalcularPromedio(suma, cont-1); 
            decimal promedio = 0;
            Promediar();
            void Promediar()
            {
                int divisor = cont - 1;
                promedio = suma / divisor;
                Console.WriteLine($"{suma} / {divisor} = Promedio = {promedio}");
            }

            bool MultiploDos(decimal prom)
            {
                if (prom % 2 == 0) return true;
                return false;
            }
            Console.WriteLine($"Es múltiplo de 2 = {MultiploDos(promedio)}");

            Console.ReadLine();
        }

        #region Funciones

        static void CalcularPromedio(int suma, int divisor)
        {
            decimal promedio = suma / divisor;
            Console.WriteLine($"{suma} / {divisor} = Promedio = {promedio}");
        }

        #endregion
    }
}
