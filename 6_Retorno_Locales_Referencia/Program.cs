using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Retorno_Locales_Referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 5: Retorno y locales por referencia 
            string[] colores = { "amarillo", "azul", "rojo", "verde" };
            Console.WriteLine($"Tercer color: {colores[3]}");
            ref string color = ref BuscarPorPosicion(3, colores); // buscamos el color en la posicion 3
            color = "negro"; // reemplaza el color encontrado en el arreglo ya que modificamos directamente su valor
            Console.WriteLine($"Tercer color después de modificar: {colores[3]}"); // imprimo para demostrar el color
            Console.ReadKey();
        }

        #region Funciones
        static ref string BuscarPorPosicion(int posicion, string[] cols)
        {
            if (cols.Length > 0)
                return ref cols[posicion];
            throw new IndexOutOfRangeException($"No existe la posición {posicion}");
        }
        #endregion
    }
}
